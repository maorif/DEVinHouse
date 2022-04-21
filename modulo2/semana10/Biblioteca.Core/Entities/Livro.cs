using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Core.Entities;

public class Livro{
    
    [Required(ErrorMessage = "O campo {0] é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo {0] é obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "O campo {0] é obrigatório")]
    public string Autor { get; set; }


}