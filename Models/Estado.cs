using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAlue.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("EstadoId")]
        [Display(Name = "Id do Estado")]

        public int EstadoId { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do Estado")]

        public string EstadoNome { get; set; } = string.Empty;
    }
}
