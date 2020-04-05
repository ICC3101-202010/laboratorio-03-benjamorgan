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

        private List<Personas> Cajeros = new List<Personas> { };
        public List<Personas> cajeros
        {
            get => Cajeros;
            set => Cajeros = cajeros;
        }


        protected string Nombre;
        public string nombre
        {
            get => Nombre;
            set
            {
                Nombre = nombre;
            }
        }
        protected string Rut;
        public string rut
        {
            get => Rut;
            set
            {
                Rut = rut;
            }
        }
        protected string Apellido;
        public string apellido
        {
            get => Apellido;
            set
            {
                Apellido = apellido;
            }
        }
        protected string Fechanacimiento;
        public string fechanacimiento
        {
            get => Fechanacimiento;
            set
            {
                Fechanacimiento = fechanacimiento;
            }
        }
        protected string Nacionalidad;
        public string nacionalidad
        {
            get => Nacionalidad;
            set
            {
                Nacionalidad = nacionalidad;
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

        public Personas()
        {
        }
        public string  Informacion()
        {

            return "Nombre: " + Nombre + ", Apellido " + Apellido + ", Rut " + Rut+", Fecha de nacimiento " + Fechanacimiento + ", Nacionalidad " + Nacionalidad;


        }

        public Personas buscarpersona(string buscado)
        {
            Personas persona0 = new Personas("", "", "", "", "");

            for (int i = 0; i < todaslaspersonas.Count(); i++)
            {
                if (todaslaspersonas[i].Nombre == buscado)
                {
                    return todaslaspersonas[i];
                }
            }
            return persona0;

        }


    }
}
