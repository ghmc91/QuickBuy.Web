using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {

        void Adicionar(TEntity entity);

        TEntity ObterPorId(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity enitity);

        void Remover(TEntity entity); 

    }
}
