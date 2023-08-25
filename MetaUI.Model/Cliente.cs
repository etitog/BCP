using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaUI.Model
{
    public class Cliente
    {
        public int Codcliente { get; set; }

        public string Tipdoc { get; set; } = null!;

        public string Numdoc { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Celular { get; set; } = null!;

        public string Estado { get; set; } = null!;

        public string Usureg { get; set; } = null!;

        public DateTime Fecreg { get; set; }

        public string Usumodif { get; set; }

        public DateTime? Fechmodif { get; set; }
    }
}
