using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public class CuponRequest
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
