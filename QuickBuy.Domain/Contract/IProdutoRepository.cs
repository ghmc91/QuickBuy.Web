using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
    }
}
