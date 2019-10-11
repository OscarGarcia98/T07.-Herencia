using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        //Hacer un objeto de cada uno y asignar propiedades individuales
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();
            Enfermera enfermero = new Enfermera();
            Fisioterapeuta fiso = new Fisioterapeuta();
            Medico medico = new Medico();
            Cirujano crjno = new Cirujano();            //Instanciación
            Familiar familiar = new Familiar();



            //asigno valores a las propiedades de cada objeto 
            paciente.Nombre = "Oscar Garcia";
            paciente.FechaNac = Convert.ToDateTime("15/05/1998");
            paciente.NoTel = "664-474-0884";
            paciente.Email = "ODGV98@GMAIL.COM";
            paciente.Direccion = "Santa Rosalía 1994";
            paciente.Estatura = 1.55M;
            paciente.Descripcion = "Tez Morena, cabello lacio";
            paciente.TipoPaciente = "Trauma";
            paciente.Peso = 154.4M;


            enfermero.Nombre = "Yulissa Mendoza";
            enfermero.FechaNac = Convert.ToDateTime("15/11/1999");
            enfermero.NoTel = "664-596-6969";
            enfermero.Email = "YuMen98@gmail.com";
            enfermero.Direccion = "De las flores #69";
            enfermero.Area = "Cuidados intensivos";

            fiso.Nombre = "Alberto Guzman";
            fiso.FechaNac = Convert.ToDateTime("10/10/1999");
            fiso.NoTel = "664-589-1414";
            fiso.Email = "bETOgUZ@hotmail.com";
            fiso.Direccion = "santa agueda #19988";
            fiso.SubEspecialidad = "fisioterapeuta pediatrico";
            fiso.Modalidad = "terapia magnetica";

            medico.Nombre = "Jose Alfredo Jimenez";
            medico.FechaNac = Convert.ToDateTime("20/04/1985");
            medico.NoTel = "664-258-2936";
            medico.Email = "Doc.JJ85@gmail.com";
            medico.Direccion = "alba roja #69";
            medico.AlmaMater = "UABC";
            medico.Especialidad = "Dermatología";
            medico.Exp = "10 años";
            medico.Horario = "7:00 - 12:00";
            medico.Sueldo = 2500M;

            crjno.Nombre = "Armando Sanchez";
            crjno.FechaNac = Convert.ToDateTime("16/02/1995");
            crjno.NoTel = "664-258-3230";
            crjno.Email = "crjno.SanchezArmando@gmail.com";
            crjno.Direccion = "de los topografos #699";
            crjno.AlmaMater = "Xochicalco";
            crjno.Especialidad = "Urología";
            crjno.Exp = "5 años";
            crjno.Horario = "14:00 - 17:00";
            crjno.Sueldo = 3000;
            crjno.CostoOperacion = 10000M;

            familiar.Nombre = "Vianey Beltran";
            familiar.FechaNac = Convert.ToDateTime("16/07/1996");
            familiar.NoTel = "664-113-5350";
            familiar.Email = "famdoc.Beltran@hotmail.com";
            familiar.Direccion = "camelias #1887";
            familiar.AlmaMater = "UABC";
            familiar.Especialidad = "podología";
            familiar.Exp = "4 años";
            familiar.Horario = "7:00 - 12:00";
            familiar.Sueldo = 1500M;
            familiar.CostoConsulta = 450M;


            
            

            




            Console.ReadKey();
        }
    }





   

}
