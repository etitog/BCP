using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaUI.Model
{
    public class Venta
    {
        public int Codventa { get; set; }

        public string Periodo { get; set; } = null!;

        public string Codasesor { get; set; } = null!;

        public int Codcliente { get; set; }

        public DateTime Fecventa { get; set; }

        public decimal Monventa { get; set; }

        public string Estado { get; set; } = null!;

        public string Usureg { get; set; } = null!;

        public DateTime Fecreg { get; set; }

        public string? Usumodif { get; set; }

        public DateTime? Fechmodif { get; set; }
    }
}
