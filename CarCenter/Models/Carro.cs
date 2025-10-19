namespace CarCenter.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateOnly AnoFabricacao { get; set; }
        public DateOnly AnoModelo { get; set; }
        public string Chassi {  get; set; }
        public double Preco {  get; set; }
    }
}
