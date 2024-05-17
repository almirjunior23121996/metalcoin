using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public class CoponAtualizarRequest
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }
    }
}
