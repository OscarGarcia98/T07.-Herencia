using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente : Persona        //Recibe atributos de Persona y contiene los propios
    {

        public string TipoPaciente { get; set; }

        public decimal Peso { get; set; }

        public decimal Estatura { get; set; }

        public string Descripcion { get; set; }
        
       


    }
}
