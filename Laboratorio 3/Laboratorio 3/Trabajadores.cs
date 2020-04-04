using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3 
{


    class Trabajadores : Personas
    {
        private List<Trabajadores> Todoslostrabajadores = new List<Trabajadores> { };
        public List<Trabajadores> todoslostrabajadores
        {
            get => Todoslostrabajadores;
            set => Todoslostrabajadores = todoslostrabajadores;
        }

        private string Puestodetrabajo;
        public string puestodetrabajo
        {
            get => Puestodetrabajo;
            set
            {
                Puestodetrabajo = puestodetrabajo;
            }
        }
        private int Sueldo;
        public int sueldo
        {
            get => Sueldo;
            set
            {
                Sueldo = sueldo;
            }
        }

        public Trabajadores(string name, string lastname, string run, string nacionality, string birthdate, string puesto,int paga)
        {
            Nombre = name;
            Apellido = lastname;
            Rut = run;
            Nacionalidad = nacionality;
            Fechanacimiento = birthdate;
            Puestodetrabajo = puesto;
            Sueldo = paga;

        }
        public new string  Informacion()
        {
            
            return "Trabajador: "+ nombre +" "+ apellido + ", Con el puesto: "+ puestodetrabajo + ","+ " sueldo: " +Sueldo ;


        }



    }
}
