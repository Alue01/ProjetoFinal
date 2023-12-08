using ProjetoFinalAlue.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAlue.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Código do Cliente")]
        public int ClienteId { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "Cpf do Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteSexo")]
        [Display(Name = "Sexo do Cliente")]
        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone do Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereço")]
        [Display(Name = "Endereço do Cliente")]
        public string ClienteEndereço { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Numero do Cliente")]
        public string ClienteNumero { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}