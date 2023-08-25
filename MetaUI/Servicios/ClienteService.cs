using MetaUI.Interfaces;
using MetaUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metas.Data.Repositorio;
using MetaUI.Data;

namespace MetaUI.Servicios
{
    public class ClienteService : IClienteService
    {
        private readonly SqlConfiguration _configuration;
        private ICliente _clienteRepositorio;

        public ClienteService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _clienteRepositorio = new ClienteRepositorio(configuration.ConnectionString);
        }

        public Task<bool> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetAllCliente()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveCliente(Cliente cliente)
        {
            if (cliente.Codcliente == 0) return _clienteRepositorio.InsertCliente(cliente);
            else return null;
        }
    }
}
