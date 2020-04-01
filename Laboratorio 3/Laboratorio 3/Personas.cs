using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    
    class Personas
    {
        private List<Personas> Todaslaspersonas = new List<Personas> { };
        public List<Personas> todaslaspersonas
        {
            get => Todaslaspersonas;
            set => Todaslaspersonas = todaslaspersonas;
        }


        private string Nombre;
        public string nombre
        {
            get => Nombre;
            set
            {
                nombre = Nombre;
            }
        }
        private string Rut;
        public string rut
        {
            get => Rut;
            set
            {
                rut = Rut;
            }
        }
        private string Apellido;
        public string apellido
        {
            get => Apellido;
            set
            {
                apellido = Apellido;
            }
        }
        private string Fechanacimiento;
        public string fechanacimiento
        {
            get => Fechanacimiento;
            set
            {
                fechanacimiento = Fechanacimiento;
            }
        }
        private string Nacionalidad;
        public string nacionalidad
        {
            get => Nacionalidad;
            set
            {
                nacionalidad = Nacionalidad;
            }
        }



        public Personas(string name,string lastname,string run,string nacionality,string birthdate )
        {
            Nombre = name;
            Apellido = lastname;
            Rut = run;
            Nacionalidad = nacionality;
            Fechanacimiento = birthdate;

        }
        public string Informacion()
        {

            return "Nombre: " + Nombre + ", Apellido " + Apellido + ", Rut " + Rut+", Fecha de nacimiento " + fechanacimiento + ", Nacionalidad " + Nacionalidad;


        }


    }
}
