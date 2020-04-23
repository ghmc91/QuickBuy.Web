using QuickBuy.Domain.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }



        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Item de pedido não pode ficar vazio");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEp não pode ser nulo");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Forma de Pagamento não informada");
                
        }
    }
}
