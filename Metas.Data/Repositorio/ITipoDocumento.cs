using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaUI.Model;
using Microsoft.Data.SqlClient;


namespace Metas.Data.Repositorio
{
    public interface ITipoDocumento
    {
        List<TipoDocumento> ListarTipo();
    }
}
