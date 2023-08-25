using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaUI.Model
{
    public class TipoDocumento
    {
        public int Cod { get; set; }

        public string Descripcion { get; set; } = null!;

        public string Estado { get; set; } = null!;

        public string Usureg { get; set; } = null!;

        public DateTime Fecreg { get; set; }

        public string Usumodif { get; set; }

        public DateTime Fechmodif { get; set; }
    }
}
