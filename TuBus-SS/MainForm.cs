using System;
using System.Windows.Forms;
using Exception = System.Exception;

namespace TuBus_SS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbEnv.SelectedIndex = 0;
        }

        private void btnParqueo_Click(object sender, EventArgs e)
        {
            try
            {
                var config = new Config
                {
                    ApiBase = (cbEnv.SelectedIndex == 0) ? tbApiBaseProd.Text : tbApiBaseDev.Text,
                    ParqueoIngreso = tbIngreso.Text,
                    ParqueoSalida = tbSalida.Text,
                    ParqueoEstado = tbParqueoEstado.Text,
                    Terminal = Convert.ToInt32(nTerminalId.Value)
                };
                var parqueo = new ParqueoForm(config);
                parqueo.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                var config = new Config
                {
                    ApiBase = (cbEnv.SelectedIndex == 0) ? tbApiBaseProd.Text : tbApiBaseDev.Text,
                    ParqueoIngreso = tbIngreso.Text,
                    ParqueoSalida = tbSalida.Text,
                    ParqueoEstado = tbParqueoEstado.Text,
                    Terminal = Convert.ToInt32(nTerminalId.Value),
                    ListaRutas = tbListaRuta.Text,
                    ListaChoferes = tbListaChofer.Text,
                    ListaBuses = tbListaBus.Text,
                    ListaTarjetas = tbListaTarjetas.Text,
                    UpdatePosicionBus = tbUpdatePosicion.Text,
                    SalidaBus = tbSalidaBus.Text,
                    LlegadaBus = tbLlegadaBus.Text,
                    IngresoPasajero = tbIngresoPasajero.Text,
                    RegistroRecorrido = tbRegistrarRecorrido.Text
                };
                var terminal = new TerminalService(config);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
