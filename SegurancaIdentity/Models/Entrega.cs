using System.ComponentModel.DataAnnotations;

namespace SegurancaIdentity.Models
{
    public class Entrega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Destinatario { get; set; }

        [Required(ErrorMessage = "Informe qual produto você deseja entregar")]
        public string Produto { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto")]
        public double Preco { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a data de entrega do produto.")]
        public string DataEntrega { get; set; }
    }
}
