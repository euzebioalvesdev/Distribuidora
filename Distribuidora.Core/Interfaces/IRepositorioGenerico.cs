namespace Distribuidora.Core.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<T?> ObterPorIdAsync(int id);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<T> CriarAsync(T entidade);
        Task AtualizarAsync(T entidade);
        Task RemoverAsync(int id);
    }
}
