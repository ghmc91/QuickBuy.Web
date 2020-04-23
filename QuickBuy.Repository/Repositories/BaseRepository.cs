using QuickBuy.Domain.Contract;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        protected readonly QuickBuyContext QuickBuyContext;

        public BaseRepository(QuickBuyContext quickBuyContext)
        {
            QuickBuyContext = quickBuyContext;

        }

        public void Adicionar(TEntity entity)
        {
            QuickBuyContext.Add(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBuyContext.Update(entity);
            QuickBuyContext.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return QuickBuyContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickBuyContext.Remove(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Dispose()
        {
            QuickBuyContext.Dispose();
        }
    }
}
