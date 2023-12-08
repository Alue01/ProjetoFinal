using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAlue.Models
{

    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("LocalRealizacaoId")]
        [Display(Name = "Código do Local Realização")]
        public int LocalRealizacaoId { get; set; }

        [Column("LocalRealizacaoNome")]
        [Display(Name = "Nome do Local Realização")]
        public string LocalRealizacaoNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}

