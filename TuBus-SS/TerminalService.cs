using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Entities;
using Newtonsoft.Json;

namespace TuBus_SS
{

    public class TerminalService
    {
        private readonly ManualResetEvent _resetEvent = new ManualResetEvent(false);
        private readonly HttpClient _client;
        private readonly Config _config;
        private List<Ruta> _rutasList;
        private List<Bus> _busList;
        private List<Chofer> _choferList;
        private List<Tarjeta> _tarjetaList;

        public TerminalService(Config config)
        {
            _config = config;
            Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Iniciando terminal " + _config.Terminal);
            Console.WriteLine($"Terminal: {_config.Terminal} -> " + $"Base address: {_config.ApiBase}{_config.Terminal}/");
            _client = new HttpClient {BaseAddress = new Uri($"{_config.ApiBase}/{_config.Terminal}/")};
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

            ThreadPool.QueueUserWorkItem(_ => GetRutas());
            ThreadPool.QueueUserWorkItem(_ => GetChoferes());
            ThreadPool.QueueUserWorkItem(_ => GetBuses());
            ThreadPool.QueueUserWorkItem(_ => GetTarjetas());
        }

        public void GetRutas()
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Obteniendo rutas: " + _config.ListaRutas);
                var response = _client.GetAsync(_config.ListaRutas).Result;

                response.EnsureSuccessStatusCode();

                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;
                _rutasList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ruta>>(dataObjects.Data.ToString());

                foreach (var ruta in _rutasList)
                {
                    ruta.Route = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonRoute>(ruta.JsonRoute);
                    ruta.RouteIndex = 0;
                }
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + _rutasList.Count + " Rutas encontradas.");

                foreach (var ruta in _rutasList)
                    ThreadPool.QueueUserWorkItem(_ => ProcessRuta(ruta));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }
 
        private void GetBuses()
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Obteniendo Buses: " + _config.ListaBuses);
                var response = _client.GetAsync(_config.ListaBuses).Result;
                response.EnsureSuccessStatusCode();
                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;
                _busList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Bus>>(dataObjects.Data.ToString());
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + _busList.Count + " Buses encontrados.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        private void GetChoferes()
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Obteniendo Choferes: " + _config.ListaChoferes);
                var response = _client.GetAsync(_config.ListaChoferes).Result;
                response.EnsureSuccessStatusCode();
                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;
                _choferList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Chofer>>(dataObjects.Data.ToString());
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + _choferList.Count + " Choferes encontrados.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        private void GetTarjetas()
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Obteniendo Tarjetas: " + _config.ListaTarjetas);
                var response = _client.GetAsync(_config.ListaTarjetas).Result;
                response.EnsureSuccessStatusCode();
                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;
                _tarjetaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tarjeta>>(dataObjects.Data.ToString());
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + _tarjetaList.Count + " Tarjetas encontradas.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        private void ProcessRuta(Ruta ruta)
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + $"Ruta {ruta.RutaName} iniciada.");
                var day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
                while (true)
                {
                    Thread.Sleep(60000); //wait 1 minute between iterations
                    var time = DateTime.Now.TimeOfDay;
                    Console.WriteLine($"Terminal: {_config.Terminal} -> " + $"Ruta {ruta.RutaName} : check {new DateTime(time.Ticks).ToString("HH:mm")}");
                    var hora = ruta.Horarios.FirstOrDefault(h => h.Dia == day && (Convert.ToInt32(h.Hora.TotalMinutes) == Convert.ToInt32(time.TotalMinutes)));
                    if (hora != null) //No existe el horario indicado.
                        ThreadPool.QueueUserWorkItem(_ => GenerateRecorrido(ruta, hora.Hora));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        public void GenerateRecorrido(Ruta ruta, TimeSpan hora)
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + $"Ruta {ruta.RutaName} : recorrido: {new DateTime(hora.Ticks).ToString("HH:mm")}");
                var buses = _busList.Where(b => b.EmpresaId == ruta.EmpresaId).ToList();
                var choferes = _choferList.Where(c => c.Empresa == ruta.EmpresaId).ToList();

                var recorrido = new Recorrido
                {
                    RutaId = ruta.Id,
                    Horario = hora,
                    ChoferCedula = choferes[new Random().Next(choferes.Count)].Cedula,
                    BusPlaca = buses[new Random().Next(buses.Count)].Id
                };
                ThreadPool.QueueUserWorkItem(_ => RunRecorrido(ruta, recorrido));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> GenRecorrido: " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        public void RunRecorrido(Ruta ruta, Recorrido recorrido)
        {
            try
            {
                var tarjetas = _tarjetaList.Where(t => t.Terminal.Id == _config.Terminal).ToList();

                recorrido = RegistroRecorrido(recorrido); // Recorrido
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + recorrido.RecorridoId + " running");

                var rnd = new Random();

                for (int i = 0; i < 3; i++) // 3 pasengers 
                {
                    var ingreso = new IngresoBus
                    {
                        RecorridoId = recorrido.RecorridoId,
                        Tarjeta = tarjetas[rnd.Next(tarjetas.Count)].CodigoUnico
                    };

                    RegistrarIngreso(ingreso);
                }

                RegistroSalida(recorrido); // Salida

                foreach (var wp in ruta.Route.Waypoints)
                {
                    Thread.Sleep(2000); // wait two seconds between points
                    var pos = new Posicion
                    {
                        RecorridoId = recorrido.RecorridoId,
                        Longitude = wp.Lng,
                        Latitude = wp.Lat
                    };
                    UpdatePosicion(pos); // Update
                }

                RegistrarLlegada(recorrido); // Llegada
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> run recorrido: " + e.Message);
            }
            finally
            {
                _resetEvent.Set();
            }
        }

        public void UpdatePosicion(Posicion pos)
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "update recorrido: " + pos.RecorridoId);
                var response = _client.PutAsJsonAsync(_config.UpdatePosicionBus, pos).Result;
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Position: " + e.Message);
            }
        }

        public Recorrido RegistroRecorrido(Recorrido recorrido)
        {
            try
            {
                var response =  _client.PostAsJsonAsync(_config.RegistroRecorrido, recorrido).Result;

                response.EnsureSuccessStatusCode();

                var dataObjects = response.Content.ReadAsAsync<ApiResponse>().Result;

                recorrido = JsonConvert.DeserializeObject<Recorrido>(dataObjects.Data.ToString());

                return recorrido;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Registro recorrido: " + e.Message);
                throw;
            }

        }

        public void RegistroSalida(Recorrido recorrido)
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Registro salida: " + recorrido.RecorridoId);
                var response = _client.PutAsJsonAsync(_config.SalidaBus, recorrido).Result;
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Registro salida: " + e.Message);
                throw;
            }
        }

        public void RegistrarLlegada(Recorrido recorrido)
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Registro llegada: " + recorrido.RecorridoId);
                var response = _client.PutAsJsonAsync(_config.LlegadaBus, recorrido).Result;
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Registro llegada: " + e.Message);
                throw;
            }
        }

        public void RegistrarIngreso(IngresoBus ingreso)
        {
            try
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + ingreso.Tarjeta + " targeta en el bus");
                var response = _client.PostAsJsonAsync(_config.IngresoPasajero, ingreso).Result;
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terminal: {_config.Terminal} -> " + "Registro ingreso: " + e.Message);
            }
        }
    }
}