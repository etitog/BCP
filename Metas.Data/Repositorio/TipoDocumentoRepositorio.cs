using Dapper;
using MetaUI.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Metas.Data.Repositorio
{
    public class TipoDocumentoRepositorio : ITipoDocumento
    {
        private string ConnnectionSçtring;

        
        public TipoDocumentoRepositorio(string connectionString)
        {
            ConnnectionSçtring = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnnectionSçtring);
        }
        public  List<TipoDocumento> ListarTipo()
        {
            var db = dbConnection();
            List<TipoDocumento> lista = new List<TipoDocumento>();
            TipoDocumento td = new TipoDocumento();
                       
            SqlCommand sql = new SqlCommand("SELECT COD, DESCRIPCION FROM TIPODOC");
            SqlDataReader lst = sql.ExecuteReader();

            if (lst.HasRows)
            {
                while (lst.Read())
                {
                    td.Cod = int.Parse( lst.GetName(1));
                    td.Descripcion = lst.GetName(2);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            return lista;
        }
    }
}
