using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaUI.Model;

namespace Metas.Data.Repositorio
{
    public interface ICliente
    {
        Task<IEnumerable<Cliente>> GetAllCliente();
        Task<Cliente> GetCliente(int id);
        Task<bool> InsertCliente(Cliente cliente);
        Task<bool> UpdateCliente(Cliente cliente);
        Task<bool> DeleteCliente(int id);
    }
}
