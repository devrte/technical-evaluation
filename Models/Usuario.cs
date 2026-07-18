using System.ComponentModel.DataAnnotations;

namespace BibliotecaLocacao.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Telefone { get; set; } = string.Empty;
        [Required]
        public string Senha { get; set; } = string.Empty;
        [Required]
        public string TipoPerfil { get; set; } = "Usuario";
        public string UserName { get; set; } = string.Empty; // Adicionando a propriedade UserName
        public string PhoneNumber { get; set; } = string.Empty; // Adicionando a propriedade PhoneNumber
    }
}