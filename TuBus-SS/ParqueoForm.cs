using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using Accord.Video;
using Accord.Video.DirectShow;
using ZXing;
using Entities;
using Newtonsoft.Json;

namespace TuBus_SS
{
    public partial class ParqueoForm : Form
    {
        private readonly ManualResetEvent _resetEvent = new ManualResetEvent(false);
        private readonly Config _config;
        private FilterInfoCollection _captureDevices;
        private VideoCaptureDevice _finalFrame;
        private HttpClient _client;
        private List<String> guids;


        public ParqueoForm(Config config)
        {
            InitializeComponent();
            _config = config;
            guids = new List<String>();
        }

        private void ParqueoForm_Load(object sender, System.EventArgs e)
        {
            _captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cbDevices.Items.Clear();
            foreach (FilterInfo device in _captureDevices)
                cbDevices.Items.Add(device.Name);
            cbDevices.SelectedIndex = 0;
            cbTipoParqueo.SelectedIndex = 0;
            _finalFrame = new VideoCaptureDevice();

            Console.WriteLine($"Parqueo: {_config.Terminal} Iniciando");
            Console.WriteLine($"Parqueo: {_config.Terminal} -> " + $"Base address: {_config.ApiBase}{_config.Terminal}/");

            _client = new HttpClient { BaseAddress = new Uri($"{_config.ApiBase}/{_config.Terminal}/") };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

            ThreadPool.QueueUserWorkItem(_ => CurrentStatusParqueo());
        }

        private void btnCamera_Click(object sender, System.EventArgs e)
        {
            if (_finalFrame.IsRunning)
            {
                tmRead.Stop();
                _finalFrame.Stop();
                btnCamera.Text = "Iniciar";
            }
            else
            {
                _finalFrame = new VideoCaptureDevice(_captureDevices[cbDevices.SelectedIndex].MonikerString);
                _finalFrame.NewFrame += new NewFrameEventHandler(NewFrame);
                _finalFrame.Start();
                tmRead.Start();
                btnCamera.Text = "Detener";
            }
        }

        private void NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pbWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + e.Message);
            }
        }

        private void ParqueoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_finalFrame.IsRunning)
                _finalFrame.Stop();
        }

        private void tmRead_Tick(object sender, System.EventArgs e)
        {
            try
            {
                var bitmap = (Bitmap)pbWebCam.Image;
                if (bitmap == null) return;
                ThreadPool.QueueUserWorkItem(_ => ProcessImage(bitmap));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + ex.Message);
            }
        }

        private void ProcessImage(Bitmap bitmap)
        {
            try
            {
                var reader = new BarcodeReader {AutoRotate = true, TryInverted = true};
                var result = reader.Decode(bitmap);

                if (result == null) return;

                var decoded = result.ToString().Trim();

                if (decoded.Equals(String.Empty)) return;

                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + "Card: " + decoded);

                var type = guids.FirstOrDefault(guid => guid.Contains(decoded)) != null;
               
                if (type)
                    guids.Remove(decoded);
                else
                    guids.Add(decoded);
            
                var reg = new RegistroParqueo
                {
                    TerminalId = _config.Terminal,
                    TarjetaId = decoded
                };

                ThreadPool.QueueUserWorkItem(_ => RegistarMovimientoParqueo(reg, type));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        private void btnManualCard_Click(object sender, EventArgs e)
        {
            var reg = new RegistroParqueo
            {
                TerminalId = _config.Terminal,
                TarjetaId = tbTarjeta.Text
            };

            var type = cbTipoParqueo.Text.Equals("Salida");

            ThreadPool.QueueUserWorkItem(_ => RegistarMovimientoParqueo(reg, type));
        }

        private void RegistarMovimientoParqueo(RegistroParqueo reg, bool isOut)
        {
            try
            {
                var path = (isOut) ?  _config.ParqueoSalida : _config.ParqueoIngreso;
                var response = _client.PostAsJsonAsync(path, reg).Result;
                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + dataObjects.Message);

                response.EnsureSuccessStatusCode();

                ThreadPool.QueueUserWorkItem(_ => CurrentStatusParqueo());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }

        }

        private void CurrentStatusParqueo()
        {
            try
            {
                var response = _client.GetAsync(_config.ParqueoEstado).Result;

                response.EnsureSuccessStatusCode();

                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + dataObjects.Message);
                var reg = JsonConvert.DeserializeObject<RegistroParqueo>(dataObjects.Data.ToString());
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + "Espacios totales: " + reg.EspaciosTotales);
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + "Espacios disponibles: " + reg.EspaciosDisponibles);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Parqueo: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }
    }
}
