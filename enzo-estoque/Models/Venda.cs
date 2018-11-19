using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enzo_estoque.Models
{
    public enum TipoSituacao
    {
        aberta,
        pendentePagamento,
        pendenteEntrega,
        entregue,
        protestada
    }
    public enum TipoPagamento
    {
        cartaoCredito,
        cheque,
        dinheiro,
        cartaoDebito,
        boleto
    }
    public class Venda
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public bool Desconto { get; set; }
        public float ValorDesconto { get; set; }
        public string EnderecoDeEntrega { get; set; }
        public TipoSituacao Situacao { get; set; }
        public TipoPagamento Pagamento { get; set; }
       //public virtual ICollection<Produto> Produtos { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}



