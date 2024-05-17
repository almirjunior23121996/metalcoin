namespace MetalCoin.Web.Spa.Core.Models
{
    public class CuponResponse
    {
        public string Code { get; set; }
        public string Descricao { get; set; }
        public double ValorDesconto { get; set; }
        public string Desconto { get; set; }
        public DateTime Validade { get; set; }
        public int TotalQuantia { get; set; }
        public int QuantiaUsada { get; set; }
        public string Status { get; set; }
    }
}
