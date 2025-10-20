using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2), MaxLength(30)]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(\(\d{2}\)\s?\d{4,5}\-?\d{4}|\d{10,11})$",
            ErrorMessage = "Informe um telefone válido.")]
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        [Required]
        public string Endereco { get; set; }
        [Required]
        [RegularExpression(@"^(\d{3}\.?\d{3}\.?\d{3}\-?\d{2}|\d{11})$",
            ErrorMessage = "Informe um CPF válido.")]
        public string Cpf { get; set; }

        public List<Nota> Notas {  get; set; } = new List<Nota>();

    }
}
