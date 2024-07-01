using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public record ProdutoCadastrarRequest
    {
        public string Nome { get; set; }
        public string Descrticao { get; set; }
        public string preco { get; set; }

    }
}
