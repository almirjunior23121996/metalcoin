
namespace MetalCoin.Api.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }

        public static implicit operator List<object>(ProdutoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
