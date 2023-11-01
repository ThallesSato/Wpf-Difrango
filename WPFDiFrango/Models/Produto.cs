﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDiFrango.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
