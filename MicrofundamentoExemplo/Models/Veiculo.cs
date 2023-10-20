using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrofundamentoExemplo.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "obrigatorio informar nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "obrigatorio informar a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "obrigatorio informar ano de fab")]

        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "obrigatorio informar ano de modelo")]

        public int AnoModelo { get; set; }
    }
}
