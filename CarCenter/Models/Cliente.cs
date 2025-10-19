namespace CarCenter.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }

        public List<Nota> Notas {  get; set; } = new List<Nota>();

    }
}
