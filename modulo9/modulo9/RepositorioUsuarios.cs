using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace modulo9
{
    public interface IRepositorioUsuarios
    {
        Task<List<Usuario>> ObtenerUsuarios();
    }

    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly ILog logger;

        public RepositorioUsuarios(ILog logger)
        {
            this.logger = logger;
        }

        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            var client = new HttpClient();
            var urlUsuarios = "https://jsonplaceholder.typicode.com/users";
            var respuestaUsuarios = await client.GetAsync(urlUsuarios);
            respuestaUsuarios.EnsureSuccessStatusCode();
            var cuerpoRespuestaUsuarios = await respuestaUsuarios.Content.ReadAsStringAsync();
            logger.Log(cuerpoRespuestaUsuarios);
            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(cuerpoRespuestaUsuarios);
            return usuarios;
        }
    }

}
