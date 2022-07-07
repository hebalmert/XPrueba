using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MiPrimer.Helpers
{
    public class Generic
    {
        //Retornar Data

        public static async Task<int> guardarGeneric<T>(string urlBase, string url, T modelo)
        {

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(urlBase)
            };

            string contenido = JsonConvert.SerializeObject(modelo);
            var content = new StringContent(contenido, Encoding.UTF8, "application/json");

            HttpResponseMessage rpta = await client.PostAsync(url, content);
            if (!rpta.IsSuccessStatusCode)
            {

                return 0;
            }
            else
            {
                int respuesta = int.Parse(await rpta.Content.ReadAsStringAsync());
                return respuesta;
            }
        }


        public static async Task<int> Delete(string urlBase, string url)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(urlBase)
            };

            HttpResponseMessage rpta = await client.DeleteAsync(url);

            //Si Existe un problema va retornar 0 porque no afecto ningun registro
            //retorna 1 porque afecto un registro, es decir, borro el registro.
            if (!rpta.IsSuccessStatusCode)
            {
                return 0;
            }
            else
            {
                var result = await rpta.Content.ReadAsStringAsync();
                return int.Parse(result);
            }

        }

        public static async Task<List<T>> GetyAll<T>(string urlBase, string url)
        {

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(urlBase)
            };

            HttpResponseMessage rpta = await client.GetAsync(url);
            if (!rpta.IsSuccessStatusCode)
            {
                return new List<T>();
            }
            else
            {
                string result = await rpta.Content.ReadAsStringAsync();
                List<T> l = JsonConvert.DeserializeObject<List<T>>(result);
                return l;
            }
        }
    }
}
