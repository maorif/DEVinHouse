using Microsoft.AspNetCore.Mvc;
using Biblioteca.Api.Interfaces;
using Biblioteca.Api.Services;

namespace Biblioteca.Api.Controllers;

[ApiController]
[Route("api/ambiente")]
public class AmbienteController : ControllerBase
{
    [HttpGet("obter")]
    public IConfiguration ObterConfig(){

        var ambiente = new AmbienteService();
        return ambiente.ObterAmbiente();
    }
}