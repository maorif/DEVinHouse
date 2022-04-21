using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Repositories;

public class RepositorioLivros
{
    public List<Livro> Lista { get; set; }

    public RepositorioLivros(){

        this.Lista = new List<Livro>();

        for (int i = 0; i < 10; i++)
        {
            var livro = new Livro
            {
                Id = i,
                Titulo = "Livro " + i,
                Autor = "Autor " + i
            };

            Lista.Add(livro);
        }
    }


}