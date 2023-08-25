using Metas.Data.Repositorio;
using MetaUI.Data;
using MetaUI.Interfaces;
using MetaUI.Model;

namespace MetaUI.Servicios
{
    public abstract class TipoDocService : ITipoDocService
    {
        private readonly SqlConfiguration _configuration;
        private ITipoDocumento _tipoDocRepositorio;

        public TipoDocService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _tipoDocRepositorio = new TipoDocumentoRepositorio(configuration.ConnectionString);
        }

        public override List<TipoDocumento> ListarTipo()
        {
            return _tipoDocRepositorio.ListarTipo();
        }
    }
}
