using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Nota
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Número da Nota")]
        public long Numero { get; set; }
        [Required]
        [Display(Name = "Data de Emissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEmissao {  get; set; }
        [Display(Name = "Garantia até")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Garantia { get; set; }
        [Required]
        [Display(Name = "Valor")]
        public double ValorVenda { get; set; }
        [Required]
        [Display(Name = "Comprador")]
        public int CompradorId { get; set; }
        [ValidateNever]
        public Cliente Comprador { get; set; }
        [Required]
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }
        [ValidateNever]
        public Vendedor Vendedor { get; set; }
        [Required]
        [Display(Name = "Carro")]
        public int CarroId { get; set; }
        [ValidateNever]
        public Carro Carro { get; set; }

    }
}
