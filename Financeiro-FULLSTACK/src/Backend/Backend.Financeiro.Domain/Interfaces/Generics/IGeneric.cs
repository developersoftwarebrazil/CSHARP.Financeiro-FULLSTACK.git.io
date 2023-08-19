namespace Backend.Financeiro.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objects);
        Task Update(T Objects);
        Task Delete(T Objects);
        Task<T> GetEntityById(int Id);
        Task<List<T>> List();
    }
}
