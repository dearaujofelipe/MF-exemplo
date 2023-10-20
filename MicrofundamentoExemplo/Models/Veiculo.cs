using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MicrofundamentoExemplo.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "obrigatorio informar nome")]
        [Display(Name = "Filme")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "obrigatorio informar a placa")]
        [Display(Name = "Diretor")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "obrigatorio informar ano de fab")]
        [Display(Name = "Metacritic Score")]

        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "obrigatorio informar ano de modelo")]
        [Display(Name = "Meu Score")]

        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
