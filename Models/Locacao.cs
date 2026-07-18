using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaLocacao.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int LivroId { get; set; }
        [ForeignKey("LivroId")]
        public Livro Livro { get; set; } = null!;
        [Required]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; } = null!;
        [Required]
        public DateTime DataRetirada { get; set; }
        public DateTime? DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoReal { get; set; }
        public decimal? Multa { get; set; }
    }
}