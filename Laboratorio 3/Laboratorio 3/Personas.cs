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
        //listas para el bonus
        private List<Personas> Bots = new List<Personas> { };
        public List<Personas> bots
        {
            get => Bots;
            set => Bots = bots;
        }
        private List<string> Botsname = new List<string> {"Benjamin","Francisco", "Joaquin", "Felipe", "Maria", "Roberto", "Maria", "Jose", "Maria Jose", "Armando", "Carlos", "Ignacia", "Josefina", "Emilia", "Camilo", "Ernesto", "Lucia", "Valeria", "Lucina", "Claudia", "Isabelle", "Martina", "Mario", "Luigi", "Ash", "Goku", "Jaime", "Laura", "Rodolfo", "Ricardo" };
        public List<string> botsname
        {
            get => Botsname;
            set => Botsname = botsname;
        }
        private List<string> Botslname = new List<string> { "Morgan", "Gracia", "Troy", "Akel", "Jimenez", "Castillo", "Bowser", "Cardenas", "Camiruaga", "Sanchez", "Gomez", "Diaz", "Ramos", "Blaco", "Bulnes", "Leon", "Cortes", "Bravo", "Pastor", "Mora", "Mateo", "Gutierres", "Marfan", "Caballero", "Barros", "Tagle", "Hirmas", "Muñoz", "Maza", "Pizarro" };
        public List<string> botslname
        {
            get => Botslname;
            set => Botslname = botslname;
        }
        private List<string> Botsrut = new List<string> { "20.285.333-1", "19.845.325-1", "18.356.241-5", "16.574.152-6", "16.452.312-k", "15.254.653-4", "13.245.365-3", "18.354.256-6", "20.321.654-3", "21.358.963-7", "20.987.654-3", "18.562.369-5", "18.452.357-6", "16.357.987-1", "14.258.321-4", "20.367.985-6", "18.357.951-5", "14.369.784-5", "15.325.963-5", "15.358.963-5", "11.258.369-5", "22.369.741-5", "18.145.267-8", "14.326.863-4", "21.369.212-1", "18.157.248-6", "14.361.258-4", "14.257.123-6", "14.874.625-6", "16.187.548-9" };
        public List<string> botsrut
        {
            get => Botsrut;
            set => Botsrut = botsrut;
        }
        private List<string> Botsdate = new List<string> {"07/10/1999","25/11/1995", "30/01/1994", "02/05/1985", "03/06/2001", "03/08/1958", "08/4/1967", "07/09/1968", "11/09/2000", "23/08/1994", "16/02/1969", "24/12/2004", "22/05/2008", "14/05/1995", "04/04/1994", "02/11/2006", "04/03/1998", "10/12/1985", "04/06/2003", "29/07/1967", "23/06/1991", "17/04/1999", "20/01/2005", "10/11/2007", "18/04/1989", "16/01/1999", "19/02/1983", "09/07/1997", "25/03/2004", "31/12/1960"  };
        public List<string> botsdate
        {
            get => Botsdate;
            set => Botsdate = botsdate;
        }
        private List<string> Botsnacinality = new List<string> { "Chileno", "Chino", "Tailandes", "Japones", "Koreano", "Mexicano", "Argentino", "Brasileño", "Estado unidense", "Polaco", "Italiano", "Griego", "Portugues", "Cubano", "Venezolano", "Ruso", "Turco", "Australiano", "Sirio", "Indio", "Croata", "Belga", "Frances", "Aleman", "Mongol", "Nunca jamas", "Canadiense", "Nigeriano", "Egipcio", "Sudafricano" };
        public List<string> botsnacionality
        {
            get => Botsnacinality;
            set => Botsnacinality = botsnacionality;
        }


        //fin de listas para el bonus
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
