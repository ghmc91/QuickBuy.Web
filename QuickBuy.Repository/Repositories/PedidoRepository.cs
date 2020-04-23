using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Context;
using QuickBuy.Repository.Repositories;

namespace QuickBuy.Repository
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
