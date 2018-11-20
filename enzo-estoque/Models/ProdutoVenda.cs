using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enzo_estoque.Models
{
    public class ProdutoVenda
    {
        public int ID { get; set; }
        public float Valor { get; set; }
        public float Quantidade { get; set; }
        public virtual Venda Venda{ get; set; }
        public virtual Produto Produto{ get; set; }
    }
}