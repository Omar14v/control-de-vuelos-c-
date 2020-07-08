using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.DAO;

namespace Ejemplo.BO
{
    class UsuarioBO : UsuarioDAO
    {

        public int codigo { get; set; }
        public string tipo { get; set; }
        public string ciudad1 { get; set; }
        public string ciudad2 { get; set; }
        public string fecha1 { get; set; }
        public string fecha2 { get; set; }
        public string estado { get; set; }
        public string hora1 { get; set; }
        public string hora2 { get; set; }

    }
}
