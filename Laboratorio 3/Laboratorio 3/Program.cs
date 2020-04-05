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
            Personas persona1 = new Personas("Don", "", "18.334.874-7", "Chileno", "04/05/80");
            persona1.todaslaspersonas.Add(persona1);
            Personas persona2 = new Personas("Benjamin", "Morgan", "18.334.874-7", "Chileno", "04/05/80");
            persona1.todaslaspersonas.Add(persona2);
            Productos producto1 = new Productos("Coca-cola 1 litro", 100, 1000, "Cocacola Company");
            producto1.todoslosproductos.Add(producto1);
            Trabajadores trabajador0 = new Trabajadores("john", "sinna", "19.696.954-2", "gringo", "01/02/85", "Cajero", 10);
            Personas persona0 = new Personas("john", "sinna", "19.696.954-2", "gringo", "01/02/85");
            persona1.todaslaspersonas.Add(persona0);
            trabajador0.todoslostrabajadores.Add(trabajador0);
            trabajador0.cajeros.Add(trabajador0);

            //menu
            while (menu != 9)
            {
                Console.WriteLine("");
                Console.WriteLine("Bienvenido a mallwart,recuerde que por su ciberseguridad  ");
                Console.WriteLine("siempre responder con los numeros indicados, que desea hacer?");
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
                int casos = 0;
                string respuesta = Console.ReadLine();
                int.TryParse(respuesta, out casos);

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
                                Console.WriteLine(("(" + (i) + ") ") +persona1.todaslaspersonas[i].Informacion());
                            }
                            string resp = Console.ReadLine();
                            Console.WriteLine("Ingrese el puesto del trabajador");
                            string puesto = Console.ReadLine();
                            if (puesto =="cajero" || puesto == "Cajero")
                            {
                                trabajador0.cajeros.Add(persona1.todaslaspersonas[Convert.ToInt32(resp)]);
                            }
                            Console.WriteLine("Ingrese el sueldo del trabajador");
                            string produ = Console.ReadLine();
                            int paga = Convert.ToInt32(produ);
                            Personas j = persona1.buscarpersona(resp);
                            Trabajadores traba = new Trabajadores(j.nombre, j.apellido, j.rut, j.nacionalidad, j.fechanacimiento, puesto, paga);
                            trabajador0.todoslostrabajadores.Add(traba);
                            Console.WriteLine("Se ascendido a " + persona1.todaslaspersonas[Convert.ToInt32(resp)].nombre + " a " + puesto);
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
                            Console.WriteLine("Cual es la marca del producto?");
                            string marc = Console.ReadLine();
                            Productos producion = new Productos(nom, produc, precic, marc);
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
                                Console.WriteLine("Pagar en caja (3)");
                                Console.WriteLine("Ver todas la boletas del dia de hoy (4)");
                                Console.WriteLine("salir del menu de compras (9)");
                                int casos2 = 0;
                                string respuesta2 = Console.ReadLine();
                                int.TryParse(respuesta2, out casos2);


                                switch (casos2)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Que producto desea comprar?");
                                            for (int i = 0; i < producto1.todoslosproductos.LongCount(); i++)
                                            {
                                                Console.WriteLine(Convert.ToString("(" + (i) + ")") + " " + producto1.todoslosproductos[i].nombre + " stock: " + producto1.todoslosproductos[i].cantidad + " Precio: " + producto1.todoslosproductos[i].precio);
                                            }
                                            string producto = Console.ReadLine();
                                            Console.WriteLine("cuanto stock del producto quiere agregar?? (ingrese 0 si no quiere el producto) ");
                                            string cant = Console.ReadLine();
                                            int casos3 = 0;
                                            int.TryParse(cant, out casos3);
                                            int casos4 = 0;
                                            int.TryParse(producto, out casos4);
                                            if (casos3 != 0)
                                            {

                                                if (casos4 == 0)
                                                {

                                                    if (producto1.todoslosproductos[Convert.ToInt32(producto)].cantidad - Convert.ToInt32(cant) >= 0)
                                                        {
                                                            producto1.carrito.Add(producto1.todoslosproductos[Convert.ToInt32(producto)].nombre);
                                                            producto1.carrito.Add(cant);
                                                            producto1.carrito.Add(Convert.ToString(producto1.todoslosproductos[Convert.ToInt32(producto)].precio));
                                                            int temporal = producto1.todoslosproductos[(Convert.ToInt32(producto))].cantidad -= Convert.ToInt32(cant);
                                                            producto1.todoslosproductos[(Convert.ToInt32(producto))].cantidad = temporal;

                                                            Console.WriteLine("producto ingresado al carro correctamente");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("hay suficiente stock, vuelva a ingresar el producto con un stock valido");
                                                            Console.WriteLine("");
                                                        }
                                                    
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ingrese un numero valido");
                                            }
                                            break;
                                        } 

                                    case 2:
                                        {
                                            for (int i = 0; i < producto1.carrito.LongCount(); i+=3)
                                            {
                                                Console.WriteLine("Producto: "+producto1.carrito[i]+", Cantidad "+ producto1.carrito[i+1]+", Precio individual: "+ producto1.carrito[i+2]);
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Hola estimado cliente, Me permite su cedula de identidad?");
                                            for (int i = 0; i < persona1.todaslaspersonas.Count(); i++)
                                            {
                                                Console.WriteLine(("(" + (i) + ") ") + persona1.todaslaspersonas[i].Informacion());

                                            }
                                            string Comprador = Console.ReadLine();
                                            int errortemp = 0;
                                            int.TryParse(Comprador, out errortemp);
                                            Random rnd = new Random();
                                            int cajero = rnd.Next(0, Convert.ToInt32(trabajador0.cajeros.LongCount()));
                                            Console.WriteLine("cajero = " + cajero);
                                            Console.WriteLine("comprador =" + Comprador);
                                            if (trabajador0.cajeros[cajero].Informacion() != persona1.todaslaspersonas[errortemp].Informacion()) 
                                            {
                                                Console.WriteLine(persona1.todaslaspersonas[errortemp].nombre + ", Muchas gracias por comprar en mallwart");

                                                Console.WriteLine("yo " + trabajador0.cajeros[cajero].nombre + " " + trabajador0.cajeros[cajero].apellido + " lo atendere como su cajero el dia de hoy, veamos que es lo que trae...");
                                                Console.WriteLine("Tome aqui esta su boleta");
                                                Console.WriteLine("");
                                                for (int i = 0; i < producto1.carrito.LongCount(); i += 3)
                                                {
                                                    Console.WriteLine("Producto: " + producto1.carrito[i] + ", Cantidad " + producto1.carrito[i + 1] + ", Precio individual: " + producto1.carrito[i + 2]);
                                                    producto1.todaslasboletas.Add("Producto: " + producto1.carrito[i] + ", Cantidad " + producto1.carrito[i + 1] + ", Precio individual: " + producto1.carrito[i + 2]);
                                                }
                                                Console.WriteLine("el total de su compra fue " + producto1.Sumacarrito() + " " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                                                producto1.todaslasboletas.Add("el total de su compra fue " + producto1.Sumacarrito() + " " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                                                Console.WriteLine("Gracias por comprar, " + persona1.todaslaspersonas[errortemp].nombre + " " + persona1.todaslaspersonas[errortemp].apellido);
                                                Console.WriteLine("Atendido por: " + trabajador0.cajeros[cajero].nombre + " " + trabajador0.cajeros[cajero].apellido);
                                                producto1.todaslasboletas.Add("Gracias por comprar, " + persona1.todaslaspersonas[errortemp].nombre + " " + persona1.todaslaspersonas[errortemp].apellido);
                                                producto1.todaslasboletas.Add("Atendido por: " + trabajador0.cajeros[cajero].nombre + " " + trabajador0.cajeros[cajero].apellido);
                                                producto1.todaslasboletas.Add("");
                                                producto1.carrito.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Cierto ,el cajero no debe comprar mientras trabaja");
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            for (int i = 0; i < producto1.todaslasboletas.LongCount(); i++)
                                            {
                                                Console.WriteLine(producto1.todaslasboletas[i]);
                                            }
                                            break;
                                        }
                                    case 9:
                                        {
                                            submenu = 0;
                                            break;
                                        }
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        break;
                                }
                            }
                   
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





