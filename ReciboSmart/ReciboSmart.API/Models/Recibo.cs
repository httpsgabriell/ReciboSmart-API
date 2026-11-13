namespace ReciboSmart.API.Models
{
    public class Recibo
    {
        public int Id { get; set; }
        public string Loja { get; set; } = string.Empty;
        public decimal ValorTotal { get; set; }
        public DateTime DataCompra { get; set; }
        public string ImagemBase64 { get; set; } = string.Empty; 
    }
}