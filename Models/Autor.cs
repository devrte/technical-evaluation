using System.ComponentModel.DataAnnotations;

namespace BibliotecaLocacao.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
    }
}