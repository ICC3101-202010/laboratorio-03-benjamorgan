using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables de funcionamiento
            int menu = 0;
            int compras = 1;
            Productos k = new Productos();
            Personas persona1 = new Personas("john", "sinna", "19.696.954-2", "gringo", "01/02/85");
            persona1.todaslaspersonas.Add(persona1);
            Productos producto1 = new Productos("Coca-cola 1 litro",100, 1000);
            producto1.todoslosproductos.Add(producto1);














            //menu
            while (menu != 9)
            {
                Console.WriteLine("");
                Console.WriteLine("Bienvenido gerente de mallwart, que desea hacer? ");
                Console.WriteLine("Crear una persona (1)");
                Console.WriteLine("Darle empleo a una persona (2)");
                Console.WriteLine("Ver lista de todas personas (3)");
                Console.WriteLine("Crear un producto (4)");
                Console.WriteLine("Ver lista de todos los productos (5)");
                Console.WriteLine("Comprar en el supermercado (6)");

                Console.WriteLine("Salir del programa (9)");
                Console.WriteLine("Solicitar simulacion de clientes (10)");
                Console.WriteLine("");
                string respuesta = Console.ReadLine();
                int casos = Convert.ToInt32(respuesta);             
                switch (casos)
                {
                    case 1:
{
                            Console.WriteLine("Ingrese un nombre");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Ingrese un apellido");
                            string ape = Console.ReadLine();
                            Console.WriteLine("Ingrese su rut");
                            string ru = Console.ReadLine();
                            Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/yyyy)");
                            string fecha = Console.ReadLine();
                            Console.WriteLine("Ingrese una nacionalidad");
                            string nacio = Console.ReadLine();
                            Personas furperson = new Personas(nom,ape,ru,nacio,fecha);
                            furperson.todaslaspersonas.Add(furperson);
                            Console.WriteLine("persona creada correctamente");
                            break;
}
                    case 2:
{
                            break;
}
                    case 3:
{
                            for (int i = 0; i < persona1.todaslaspersonas.Count(); i++)
                            {
                                Console.WriteLine(persona1.todaslaspersonas[i].Informacion());
                            }
                            break;
}

                    case 4:
{
                            Console.WriteLine("Ingrese un nombre");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Ingrese una cantidad de productos");
                            string produ = Console.ReadLine();
                            int produc = Convert.ToInt32(produ);
                            Console.WriteLine("Ingrese el precio del producto");
                            string preci = Console.ReadLine();
                            int precic = Convert.ToInt32(preci);
                            Productos producion = new Productos(nom, produc, precic);
                            producion.todoslosproductos.Add(producion);
                            Console.WriteLine("Producto creado exitosamente");
                            break;

}
                    case 5:
{
                            while (compras != 0)
                            {
                                Console.WriteLine("Que producto desea comprar?");
                                for (int i = 0; i < k.todoslosproductos.LongCount(); i++)
                                {
                                    Console.WriteLine(k.todoslosproductos[i]);
                                }
                                string producto = Console.ReadLine();

                            }
                            break;
}
                    case 6:
{
                            break;
}
                    case 9:
{
                            menu = 9;
                            break;
}
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }







            }
        }
    }
}
