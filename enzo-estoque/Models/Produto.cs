using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enzo_estoque.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}