using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.ObjetoDeValor
{
    public class FormaPagamento : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhCartao
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
