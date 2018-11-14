using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enzo_estoque.Models
{
    public class Fornecedor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
    }
}