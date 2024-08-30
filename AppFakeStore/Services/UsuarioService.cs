using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AppFakeStore.Models;

namespace AppFakeStore.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly HttpClient _httpClient;// para enviar solicitudes HTTP

        public UsuariosService()
        {
            _httpClient = new HttpClient(); //Ctor para enviar datos a la api
        }

        public async Task<List<Usuarios>> ObtenerUsuariosAsync()
        {
            var usuarios = await _httpClient.GetFromJsonAsync<List<Usuarios>>("https://fakestoreapi.com/users");
            return usuarios; //Como es la lista completa retorna todo
        }
    }
}
