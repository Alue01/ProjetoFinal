using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalAlue.Models
{
    [Table("ProcedimentosRealizados")]
    public class ProcedimentoRealizado
    {
        [Column("ProcedimentosRealizadosId")]
        [Display(Name = " Código do ProcedimentosRealizados")]
        public int ProcedimentoRealizadoId { get; set; }



        [ForeignKey("ClienteId")]
        [Display(Name = " Código do Cliente")]
        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }


        [ForeignKey("ProcedimentosId")]
        [Display(Name = " Código do Procedimento")]
        public int? ProcedimentosId { get; set; }

        public Procedimentos? Procedimentos { get; set; }


        [ForeignKey("ColaboradorId")]
        [Display(Name = " Código do Colaborador")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        [Display(Name = " Código do Local da Realizacao")]
        public int? LocalRealizacaoId { get; set; }

        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizadoId")]
        [Display(Name = " Código do Data da Realizado")]
        public DateTime DataRealizadoId { get; set; }

        [Column("ObservacaoRealizadoId")]
        [Display(Name = " Código do Observacao da Realizado")]
        public string ObservacaoRealizadoId { get; set; } = string.Empty;
    }
}
