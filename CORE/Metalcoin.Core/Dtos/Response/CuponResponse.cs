using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Response
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
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; set; }
    }
}

