using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Enumerados
{
    public enum TipoFormaPagamentoEnum 
    {
        NaoDefinido = 0,
        Boleto = 1,
        CartaCredito = 2,
        Deposito = 3

    }
}
