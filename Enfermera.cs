using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Enfermera : Persona       //Reciben atributos de la superclase
    {
        public string Area { get; set; }

    }

    class Fisioterapeuta : Persona
    {
        public string SubEspecialidad { get; set; }

        public string Modalidad { get; set; }


    }


}
