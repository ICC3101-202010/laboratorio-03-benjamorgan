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
        private List<Trabajadores> Empleadosauto = new List<Trabajadores> { };
        public List<Trabajadores> empleadosauto
        {
            get => Empleadosauto;
            set => Empleadosauto = empleadosauto;
        }
        private List<string> Botspuesto = new List<string> {"Cajero","Auxiliar","Reponedor"};
        public List<string> botspuesto
        {
            get => Botspuesto;
            set => Botspuesto = botspuesto;
        }
        //paga en mono-dolares (y al pasar por el banco solo dan 30)
        private List<int> Botspaga = new List<int> { 150,100, 80,200 };
        public List<int> botspaga
        {
            get => Botspaga;
            set => Botspaga = botspaga;
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
        private string Horario;
        public string horario
        {
            get => Horario;
            set
            {
                Horario = horario;
            }
        }
        public Trabajadores(string name, string lastname, string run, string nacionality, string birthdate, string puesto,int paga, string horario)
        {
            Nombre = name;
            Apellido = lastname;
            Rut = run;
            Nacionalidad = nacionality;
            Fechanacimiento = birthdate;
            Puestodetrabajo = puesto;
            Sueldo = paga;
            Horario = horario;

        }
        public new string  Informacion()
        {
            
            return "Trabajador: "+ nombre +" "+ apellido + ", Con el puesto: "+ puestodetrabajo + ","+ " sueldo: " +Sueldo + ", Horario: "+ Horario ;


        }



    }
}
