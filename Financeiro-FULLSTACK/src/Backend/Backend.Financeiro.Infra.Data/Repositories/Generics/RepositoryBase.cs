using Backend.Financeiro.Domain.Interfaces.Generics;
using Backend.Financeiro.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Financeiro.Infra.Data.Repositories.Generics
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DbContextOptions<TransactiondbContext> _options;
        public RepositoryBase()
        {
            _options = new DbContextOptions<TransactiondbContext>();
        }
        public async Task Add(TEntity Objects)
        {
            using (var data = new TransactiondbContext(_options))
            {
                await data.Set<TEntity>().AddAsync(Objects);
                await data.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity Objects)
        {
            using(var data=new TransactiondbContext(_options))
            {
                data.Set<TEntity>().Update(Objects);
                await data.SaveChangesAsync();
            }
        }
        public async Task Delete(TEntity Objects)
        {
            using(var data = new TransactiondbContext(_options))
            {
                data.Set<TEntity>().Remove(Objects);
                await data.SaveChangesAsync();
            }
        }


        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetEntityById(int Id)
        {
           using(var data = new TransactiondbContext(_options))
            {
               return await data.Set<TEntity>().FindAsync(Id);
            }
        }

        public async Task<List<TEntity>> List()
        {
            using (var data = new TransactiondbContext(_options))
            {
                return await data.Set<TEntity>().ToListAsync();
            }
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
    }
}
