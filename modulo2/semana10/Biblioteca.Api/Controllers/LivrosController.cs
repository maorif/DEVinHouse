using Microsoft.AspNetCore.Mvc;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;

namespace Biblioteca.Api.Controllers;

[ApiController]
[Route("api/livros")]
public class LivrosController : ControllerBase
{

    public LivrosController()
    {
    }

    [HttpGet]
    public ActionResult<RepositorioLivros> ObterTodos(){

        var livros = new RepositorioLivros();

        return Ok(livros);
    }

    [HttpGet("obter-por-id")]
    public ActionResult<Livro> ObterPorId(int livroId){

        var livros = new RepositorioLivros();

        return Ok(livros.Lista.Where(livro => livro.Id == livroId));
    }

    [HttpPost("inserir")]
    public ActionResult<Livro> Inserir(Livro livro){

        if(!ModelState.IsValid) return BadRequest();
        
        try
        {
            var livros = new RepositorioLivros();
            livros.Lista.Add(livro);
            return Ok(livro);
        }
        catch (System.Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpPut("atualizar")]
    public ActionResult Atualizar(){

        // return Ok();

        return Unauthorized();
    }

    [HttpDelete("excluir")]
    public ActionResult Excluir(int id){

        if(!ModelState.IsValid) return BadRequest();

        var livros = new RepositorioLivros();
        var livroExcluir = livros.Lista.Single(l => l.Id == id);
        livros.Lista.Remove(livroExcluir);

        // return Ok(livroExcluir);
        return StatusCode(403);
    }
}
