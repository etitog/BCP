using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaUI.Model
{
    public class Producto
    {
        public int Codprod { get; set; }

        public string Producto1 { get; set; } = null!;

        public decimal Punto { get; set; }

        public string Estado { get; set; } = null!;

        public string Usureg { get; set; } = null!;

        public DateTime Fecreg { get; set; }

        public string? Usumodif { get; set; }

        public DateTime? Fechmodif { get; set; }
    }
}
