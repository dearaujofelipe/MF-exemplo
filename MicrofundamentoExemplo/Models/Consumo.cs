using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrofundamentoExemplo.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "informar a descricao")]
        [Display(Name = "Description")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "informar o km")]
        public int Km { get; set; }

        [Display(Name ="Tipo do Combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veiculo")]
        [Required(ErrorMessage = "obrigatorio informar o veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }

}
