using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Persona       //Esta es la clase principal la cual heredará al resto de clases, contiene atributos que el resto utiliza
    {
        public string Nombre { get; set; }

        public DateTime FechaNac { get; set; }

        public string NoTel { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

      


    }
}
