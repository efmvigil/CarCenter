namespace CarCenter.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public long Numero { get; set; }
        public DateOnly DataEmissao {  get; set; }
        public DateOnly Garantia { get; set; }
        public double ValorVenda { get; set; }
        public Cliente Comprador { get; set; }
        public Vendedor Vendedor { get; set; }
        public Carro Carro { get; set; }

    }
}
