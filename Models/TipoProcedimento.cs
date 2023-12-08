using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalAlue.Models
{

        [Table("TipoProcedimento")]
        public class TipoProcedimento
        {

            [Column("Id")]
            [Display(Name = "Código do Tipo Procedimento")]
            public int Id { get; set; }

            [Column("TipoProcedimentoNome")]
            [Display(Name = "Nome do TipoProcedimento")]
            public string TipoProcedimentoNome { get; set; } = string.Empty;

        }
}
