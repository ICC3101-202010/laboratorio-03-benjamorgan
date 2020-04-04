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

            Productos k = new Productos();
            Personas persona1 = new Personas("john", "sinna", "19.696.954-2", "gringo", "01/02/85");
            persona1.todaslaspersonas.Add(persona1);
            Productos producto1 = new Productos("Coca-cola 1 litro", 100, 1000);
            producto1.todoslosproductos.Add(producto1);
            Trabajadores trabajador0 = new Trabajadores("john", "sinna", "19.696.954-2", "gringo", "01/02/85", "don nadie", 10);
            trabajador0.todoslostrabajadores.Add(trabajador0);















            //menu
            while (menu != 9)
            {
                Console.WriteLine("");
                Console.WriteLine("Bienvenido gerente de mallwart, que desea hacer? ");
                Console.WriteLine("Crear una persona (1)");
                Console.WriteLine("Darle empleo a una persona (2)");
                Console.WriteLine("Ver lista de todas personas (3)");
                Console.WriteLine("Ver lista de todos los trabajadores (4)");
                Console.WriteLine("Crear un producto (5)");
                Console.WriteLine("Ver lista de todos los productos (6)");
                Console.WriteLine("Comprar en el supermercado (7)");

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
                            Personas furperson = new Personas(nom, ape, ru, nacio, fecha);
                            persona1.todaslaspersonas.Add(furperson);
                            Console.WriteLine("persona creada correctamente");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("A quien de los siguientes le quiere dar empleo?");
                            for (int i = 0; i < persona1.todaslaspersonas.Count(); i++)
                            {
                                Console.WriteLine(persona1.todaslaspersonas[i].Informacion());
                            }
                            string resp = Console.ReadLine();
                            Console.WriteLine("Ingrese el puesto del trabajador");
                            string puesto = Console.ReadLine();
                            Console.WriteLine("Ingrese el sueldo del trabajador");
                            string produ = Console.ReadLine();
                            int paga = Convert.ToInt32(produ);
                            Personas j = persona1.buscarpersona(resp);
                            Trabajadores traba = new Trabajadores(j.nombre, j.apellido, j.rut, j.nacionalidad, j.fechanacimiento, puesto, paga);
                            trabajador0.todoslostrabajadores.Add(traba);
                            Console.WriteLine("Se ascendido a " + resp + " a " + puesto);
                            break;
                        }
                    case 3:
                        {
                            for (int i = 0; i <= persona1.todaslaspersonas.Count(); i++)
                            {
                                Console.WriteLine(persona1.todaslaspersonas[i].Informacion());
                                Console.WriteLine("jaja");
                            }
                            break;
                        }

                    case 4:
                        {
                            for (int i = 0; i < trabajador0.todoslostrabajadores.Count(); i++)
                            {
                                Console.WriteLine(trabajador0.todoslostrabajadores[i].Informacion());
                            }
                            break;
                        }
                    case 5:
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
                            producto1.todoslosproductos.Add(producion);
                            Console.WriteLine("Producto creado exitosamente");
                            break;
                        }
                    case 6:
                        {
                            for (int i = 0; i < producto1.todoslosproductos.Count(); i++)
                            {
                                Console.WriteLine(producto1.todoslosproductos[i].Informacion());
                            }
                            break;

                        }
                    case 7:
                        {
                            int submenu = 1;
                            while (submenu != 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Que desea hacer?");
                                Console.WriteLine("Agregar un producto al carrito (1)");
                                Console.WriteLine("Ver productos del carrito (2)");
                                Console.WriteLine("salir del menu de compras (9)");
                                submenu = Convert.ToInt32(Console.ReadLine());
                                switch (submenu)
                                {


                                    case 1:
                                        {
                                            Console.WriteLine("Que producto desea comprar?");
                                            for (int i = 0; i < producto1.todoslosproductos.LongCount(); i++)
                                            {
                                                Console.WriteLine(Convert.ToString("(" + (i ) + ")") + " " + producto1.todoslosproductos[i].nombre + " stock: " + producto1.todoslosproductos[i].cantidad);
                                            }
                                            string producto = Console.ReadLine();
                                            Console.WriteLine("cuanto stock del producto quiere agregar?? (ingrese 0 si no quiere el producto) ");
                                            string cant = Console.ReadLine();
                                            if (producto1.todoslosproductos[Convert.ToInt32(producto) ].cantidad - Convert.ToInt32(cant) >= 0)
                                            {                                
                                                producto1.carrito.Add(producto1.todoslosproductos[Convert.ToInt32(producto)].nombre);
                                                producto1.carrito.Add(cant);
                                                producto1.todoslosproductos[(Convert.ToInt32(producto))].cantidad = producto1.todoslosproductos[(Convert.ToInt32(producto))].cantidad - Convert.ToInt32(cant);
                                                Console.WriteLine("producto ingresado al carro correctamente");
                                            }
                                            else
                                            {
                                                Console.WriteLine("hay suficiente stock, vuelva a ingresar el producto con un stock valido");
                                                Console.WriteLine("");
                                            }
                                            break;
                                        }

                                    case 2:
                                        {
                                            for (int i = 0; i < producto1.carrito.LongCount(); i+=2)
                                            {
                                                Console.WriteLine("Producto: "+producto1.carrito[i]+", Cantidad "+ producto1.carrito[i+1]);
                                            }
                                            break;
                                        }
                                    case 9:
                                        {
                                            submenu = 0;
                                            break;
                                        }


                                }



                            }
                       
                            //for (int i = 0; i < producto1.carrito.LongCount(); i++)
                            //{
                            //    Console.WriteLine(producto1.carrito[i]);
                            //}
                        }
                        break;
                        
        
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





