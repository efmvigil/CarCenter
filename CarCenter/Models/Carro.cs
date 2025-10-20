using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Range(1900, 2100)]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }        
        [Range(1900, 2100)]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
        [Required]
        public string Chassi {  get; set; }
        [Display(Name = "Preço")]
        public double Preco {  get; set; }
    }
}
