﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public record CuponCadastrarRequest
    {
        public string Descrticao { get; set; }
        public bool Status { get; set; }
    }
}
