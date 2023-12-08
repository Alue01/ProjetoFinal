using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAlue.Models
{
    [Table("Procedimentos")]
    public class Procedimentos
    {
        [Column("ProcedimentosId")]
        [Display(Name = "Código do Procedimentos")]
        public int ProcedimentosId { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome do Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação do Procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoProcedimentoId")]
        public int TipoProcedimentoId { get; set; }

        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}


