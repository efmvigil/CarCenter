namespace CarCenter.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public List<Nota> Notas { get; set; } = new List<Nota>();
        public double calcularComissao() { return Salario; }
    }
}
