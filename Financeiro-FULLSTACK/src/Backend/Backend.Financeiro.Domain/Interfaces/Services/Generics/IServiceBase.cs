using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Financeiro.Domain.Interfaces.Services.Generics
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add (TEntity Objects);
        void Update (TEntity Objects);
        void Delete (TEntity Objects);
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll();
        void Dispose();
    }
}
