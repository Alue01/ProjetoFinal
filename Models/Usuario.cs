using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAlue.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código do Usuário")]

        public string UsuarioId { get; set; } = string.Empty;

        [Column("Nome")]
        [Display(Name = "Nome")]

        public string Nome { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]

        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]

        public string Senha { get; set; } = string.Empty;
    }
}
