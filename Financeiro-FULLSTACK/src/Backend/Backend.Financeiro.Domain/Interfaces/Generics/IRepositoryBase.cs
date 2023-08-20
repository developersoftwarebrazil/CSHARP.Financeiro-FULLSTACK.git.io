namespace Backend.Financeiro.Domain.Interfaces.Generics
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task Add(TEntity Objects);
        Task Update(TEntity Objects);
        Task Delete(TEntity Objects);
        Task<TEntity> GetEntityById(int Id);
        Task<List<TEntity>> List();

        IEnumerable<TEntity> GetAll(); 

        void Dispose();

    }
}
