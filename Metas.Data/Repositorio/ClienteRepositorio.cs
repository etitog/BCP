using Dapper;
using MetaUI.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metas.Data.Repositorio
{
    public class ClienteRepositorio : ICliente
    {
        private string ConnnectionSçtring;

        public ClienteRepositorio (string connectionString)
        {
            ConnnectionSçtring = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnnectionSçtring);
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

        public async Task<bool> InsertCliente(Cliente cliente)
        {
            var db = dbConnection();
            string estadocliente = "1";
            string usuarioRegistro = "ETITO";
            DateTime fechaRegistro = DateTime.Now;

            cliente.Estado = estadocliente;
            cliente.Usureg = usuarioRegistro;
            cliente.Fecreg = fechaRegistro;

            var sql = @"INSERT INTO CLIENTE(TIPDOC,NUMDOC,NOMBRES,APELLIDOS,CELULAR,ESTADO,USUREG,FECREG)
                        VALUES(@TIPDOC, @NUMDOC,@NOMBRES,@APELLIDOS, @CELULAR, @ESTADO,@USUREG,@FECREG)";
            var result = await db.ExecuteAsync(sql.ToString(), 
                new { cliente.Codcliente, cliente.Tipdoc, cliente.Numdoc,cliente.Nombres, cliente.Apellidos, cliente.Celular, 
                    cliente.Estado, cliente.Usureg, cliente.Fecreg});
            return result > 0;
        }

        public Task<bool> UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
