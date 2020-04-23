using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUsuarioRepository
    {
        public UserRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
