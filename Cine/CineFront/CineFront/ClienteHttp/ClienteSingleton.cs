using CineBack.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFront.ClienteHttp
{
    public class ClienteSingleton
    {
        public static ClienteSingleton instancia;
        private HttpClient cliente;

        private ClienteSingleton()
        {
            cliente = new HttpClient();
        }

        public static ClienteSingleton getInstance() {
            if (instancia == null)
            {
                instancia = new ClienteSingleton();
            }              
            return instancia;
            
        }

        public async Task<string> GetAsync(string url)
        {
            //var result = await cliente.GetAsync(url);
            //var content = "";
            //if (result.IsSuccessStatusCode)
            //    content = await result.Content.ReadAsStringAsync();
            //return content;
            try
            {
                // Hacer la solicitud GET
                HttpResponseMessage response = await cliente.GetAsync(url);

                // Verificar si la solicitud fue exitosa (código de estado 200)
                if (response.IsSuccessStatusCode)
                {
                    // Leer y procesar el contenido de la respuesta
                    string content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                {
                    return $"Error en la solicitud. Código de estado: {response.StatusCode}";
                    //Console.WriteLine($"Error en la solicitud. Código de estado: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                return $"Error de solicitud HTTP: {e.Message}";
            }
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await cliente.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await cliente.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> DeleteAsync(string url,string data)
        {
            //StringContent content = new StringContent(data,Encoding)
            var result = await cliente.DeleteAsync(url);
            var response = "";
            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }

            //JsonConvert.SerializeObject();
            return response;
        }


    }
}
