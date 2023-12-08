using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalAlue.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = "Id da Cidade")]

        public int CidadeId { get; set; }


        [Column("CidadeNome")]
        [Display(Name = "Nome da Cidade")]

        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
