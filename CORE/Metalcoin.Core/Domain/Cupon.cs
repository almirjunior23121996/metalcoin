using Metalcoin.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//aqui estabeleço todas as propriedades que o cupom vai ter
namespace Metalcoin.Core.Domain
{
    
    public class Cupon : Entidade
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
