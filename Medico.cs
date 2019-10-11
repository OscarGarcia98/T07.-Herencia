using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medico : Persona
    {
        public string AlmaMater { get; set; }
        public string Especialidad { get; set; }

        public string Exp { get; set; }

        public string Horario { get; set; }

        public decimal Sueldo { get; set; }

    }

    class Cirujano  : Medico        //La clase cirujano y medFamiliar reciben atributos de la clase médico y a la misma vez de la superclase Persona
    {
        public decimal CostoOperacion { get; set; }

    }

    class Familiar  : Medico
    {
        public decimal CostoConsulta { get; set; }


    }




}
