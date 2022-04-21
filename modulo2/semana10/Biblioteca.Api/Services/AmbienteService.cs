using Biblioteca.Api.Interfaces;

namespace Biblioteca.Api.Services
{
    public class AmbienteService : IAmbienteService
    {
        private readonly IConfiguration _configuration;
        AmbienteService(IConfiguration configuration){
            this._configuration = configuration;
        }

        public IConfiguration ObterAmbiente() => this._configuration.GetSection("NomeAmbiente");
    }
}