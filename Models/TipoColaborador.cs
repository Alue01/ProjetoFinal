using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalAlue.Models
{
        [Table("TipoColaborador")]
        public class TipoColaborador
        {
            [Column("TipoColaboradorId")]
            [Display(Name = "Código do Tipo Colaborador")]
            public int TipoColaboradorId { get; set; }

            [Column("TipoColaboradorNome")]
            [Display(Name = "Nome do TipoColaborador")]
            public string TipoColaboradorNome { get; set; } = string.Empty;
        }
}
