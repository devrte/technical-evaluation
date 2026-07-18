using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaLocacao.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } = string.Empty;
        [Required]
        public string Autor { get; set; } = string.Empty;
        [Required]
        public string Editora { get; set; } = string.Empty;
        [Required]
        public int AnoPublicacao { get; set; }
        [Required]
        public string ISBN { get; set; } = string.Empty;
        [Required]
        public int Quantidade { get; set; }
    }
}