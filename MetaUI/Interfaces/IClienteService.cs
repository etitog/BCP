using MetaUI.Model;


namespace MetaUI.Interfaces
{
    public interface IClienteService 
    {
        Task<IEnumerable<Cliente>> GetAllCliente();
        Task<Cliente> GetCliente(int id);
        Task<bool> SaveCliente(Cliente cliente);
        
        Task<bool> DeleteCliente(int id);
    }
}
