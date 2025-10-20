using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2), MaxLength(30)]
        public string Nome { get; set; }
        [Display(Name = "Data de Admissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataAdmissao { get; set; }
        [Required]
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public List<Nota> Notas { get; set; } = new List<Nota>();
        public double calcularComissao(DateTime inicio, DateTime fim, double percentualBase = 0.02) {
            var vendas = (Notas ?? Enumerable.Empty<Nota>())
           .Where(n => n.DataEmissao >= inicio && n.DataEmissao <= fim)
           .Sum(n => n.ValorVenda);

            var bonus = vendas >= 200_000 ? 0.01
                      : vendas >= 100_000 ? 0.005
                      : 0.0;

            return Math.Round(vendas * (percentualBase + bonus), 2, MidpointRounding.AwayFromZero);
        }
    }
}
