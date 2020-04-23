using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Entities
{
    public class ItemPedido : Entidade
        
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Id do Produto não identificado");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não informada");
        }
    }
}
