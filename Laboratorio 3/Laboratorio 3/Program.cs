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
            //nota en el programa hay alteracion de nombres para el copirigth 
            int menu = 0;

            Productos k = new Productos();
            Personas persona1 = new Personas("Don", "", "", "", "");
            persona1.todaslaspersonas.Add(persona1);
            Personas persona2 = new Personas("Benjamin", "Morgan", "20.285.333-1", "Chileno", "04/05/80");
            persona1.todaslaspersonas.Add(persona2);
            Productos producto1 = new Productos("Coca-cola 1 litro", 100, 1000, "Cocacola Company");
            producto1.todoslosproductos.Add(producto1);
            Trabajadores trabajador0 = new Trabajadores("john", "sinna", "19.696.954-2", "gringo", "01/02/85", "Cajero", 100);
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
                Console.WriteLine("(1) Crear una persona ");
                Console.WriteLine("(2) Darle empleo a una persona ");
                Console.WriteLine("(3) Ver lista de todas personas ");
                Console.WriteLine("(4) Ver lista de todos los trabajadores ");
                Console.WriteLine("(5) Crear un producto ");
                Console.WriteLine("(6) Ver lista de todos los productos ");
                Console.WriteLine("(7) Comprar en el supermercado ");
                Console.WriteLine("(8) Solicitar simulacion de clientes ");
                Console.WriteLine("(9) Salir del programa ");

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
                                Console.WriteLine(("(" + (i) + ") ") + persona1.todaslaspersonas[i].Informacion());
                            }
                            string resp = Console.ReadLine();
                            Console.WriteLine("Ingrese el puesto del trabajador");
                            string puesto = Console.ReadLine();
                            if (puesto == "cajero" || puesto == "Cajero")
                            {
                                trabajador0.cajeros.Add(persona1.todaslaspersonas[Convert.ToInt32(resp)]);
                            }
                            Console.WriteLine("Ingrese el sueldo del trabajador");
                            string produ = Console.ReadLine();
                            int paga = Convert.ToInt32(produ);
                            Personas j = persona1.buscarpersona(persona1.todaslaspersonas[Convert.ToInt32(resp)].nombre);
                            Trabajadores traba = new Trabajadores(j.nombre, j.apellido, j.rut, j.nacionalidad, j.fechanacimiento, puesto, paga);
                            Console.WriteLine(j.nombre+ j.apellido+ j.rut+ j.nacionalidad+ j.fechanacimiento+ puesto+ paga);
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
                                Console.WriteLine("(1) Agregar un producto al carrito ");
                                Console.WriteLine("(2) Ver productos del carrito ");
                                Console.WriteLine("(3) Pagar en caja ");
                                Console.WriteLine("(4) Ver todas la boletas del dia de hoy ");
                                Console.WriteLine("(9) Salir del menu de compras ");
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
                                            Console.WriteLine("cuanto stock del producto quiere agregar?? ");
                                            string cant = Console.ReadLine();
                                            int casos3 = 0;
                                            int.TryParse(cant, out casos3);
                                            int casos4 = 0;
                                            int.TryParse(producto, out casos4);
                                            if (casos3 != 0)
                                            {

                                                if (casos4 >= 0)
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
                                            for (int i = 0; i < producto1.carrito.LongCount(); i += 3)
                                            {
                                                Console.WriteLine("Producto: " + producto1.carrito[i] + ", Cantidad " + producto1.carrito[i + 1] + ", Precio individual: " + producto1.carrito[i + 2]);
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
                                            if (trabajador0.cajeros[cajero].Informacion() != persona1.todaslaspersonas[errortemp].Informacion())
                                            {
                                                Console.WriteLine(persona1.todaslaspersonas[errortemp].nombre + ", Muchas gracias por comprar en mallwart");

                                                Console.WriteLine("yo " + trabajador0.cajeros[cajero].nombre + " " + trabajador0.cajeros[cajero].apellido + " lo atendere como su cajero el dia de hoy, veamos que es lo que trae...");
                                                Console.WriteLine("Tome aqui esta su boleta");
                                                Console.WriteLine("--------------------------");
                                                for (int i = 0; i < producto1.carrito.LongCount(); i += 3)
                                                {
                                                    Console.WriteLine("Producto: " + producto1.carrito[i] + ", Cantidad " + producto1.carrito[i + 1] + ", Precio individual: " + producto1.carrito[i + 2]);
                                                    producto1.todaslasboletas.Add("Producto: " + producto1.carrito[i] + ", Cantidad " + producto1.carrito[i + 1] + ", Precio individual: " + producto1.carrito[i + 2]);
                                                }
                                                Console.WriteLine("el total de su compra fue " + producto1.Sumacarrito() + " " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                                                producto1.todaslasboletas.Add("el total de su compra fue " + producto1.Sumacarrito() + " " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                                                producto1.todaslasboletas.Add("--------------------------");
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
                            break;
                        }

                    case 8: //bonus
                        {
                            //creacion clientes
                            Console.WriteLine("");
                            Random rndname = new Random();
                            for (int i = 0; i < 15; i++)
                            {
                                
                                int botnamae = rndname.Next(0,30);

                                int botlnamae = rndname.Next(0, 30);

                                int botrun = rndname.Next(0, 30);

                                int botdate = rndname.Next(0, 30);

                                int botnacio = rndname.Next(0, 30);
                                Personas SujetodePruebas = new Personas(persona1.botsname[botnamae], persona1.botslname[botlnamae], persona1.botsrut[botrun], persona1.botsnacionality[botnacio], persona1.botsdate[botdate] );
                                persona1.bots.Add(SujetodePruebas);
                            }
                            //creacion empleados

                            for (int i = 0; i < 6; i++)
                            {
                                int botnamae = rndname.Next(0, 30);                             
                                int botlnamae = rndname.Next(0, 30);
                                int botrun = rndname.Next(0, 30);
                                int botdate = rndname.Next(0, 30);
                                int botnacio = rndname.Next(0, 30);
                                int botpuesto = rndname.Next(0, 3);
                                int botpaga = rndname.Next(0, 4);
                                Trabajadores SujetodePruebas = new Trabajadores(persona1.botsname[botnamae], persona1.botslname[botlnamae], persona1.botsrut[botrun], persona1.botsdate[botdate], persona1.botsnacionality[botnacio],trabajador0.botspuesto[botpuesto],trabajador0.botspaga[botpaga]);
                                trabajador0.empleadosauto.Add(SujetodePruebas);
                            }
                            //me aseguro de que siempre halla un cajero (es importante)
                            Trabajadores Empleadopromedio = new Trabajadores("Keannue", "Rieves", "19.696.954-2", "gringo", "01/02/85", "Cajero", 100);
                            trabajador0.empleadosauto.Add(Empleadopromedio);
                            //creacion productos
                            for (int i = 0; i < 30; i++)
                            {
                                int produnamae = rndname.Next(0, 40);                                
                                int produmark = rndname.Next(0, 10);                              
                                int produprecio = rndname.Next(0, 10);                              
                                int produstock = rndname.Next(0, 8);
                                Productos Productoprueba = new Productos(producto1.nombreprodu[produnamae], producto1.stockprodu[produstock], producto1.precioprodu[produprecio], producto1.marcaprodu[produmark]);
                                producto1.productossimulacion.Add(Productoprueba);
                            }
                            for (int i = 0; i < persona1.bots.LongCount(); i++)
                            {
                                Console.WriteLine(persona1.bots[i].Informacion());
                            }
                            Console.WriteLine("");
                            for (int i = 0; i < trabajador0.empleadosauto.LongCount(); i++)
                            {
                            Console.WriteLine(trabajador0.empleadosauto[i].Informacion());
                            }
                            Console.WriteLine("");
                            for (int i = 0; i < producto1.productossimulacion.LongCount(); i++)
                            {
                                Console.WriteLine(producto1.productossimulacion[i].Informacion());
                            }
                            Console.WriteLine("");
                            for (int i = 0; i < 5; i++)
                            {

                            
                            Console.WriteLine("Hola estimado cliente, Me permite su cedula de identidad?");
                            int bot = rndname.Next(0, 15);
                            int cajero = rndname.Next(0, 7);
                            Console.WriteLine(persona1.bots[bot].Informacion()); 
                            Console.WriteLine(persona1.bots[bot].nombre + ", Muchas gracias por comprar en mallwart");
                            for (int K = 0; K < 5; K++)
                            {
                                int producto = rndname.Next(0, 30);
                                int cantidad = rndname.Next(0, 15); //cada uno se puede llevar maximo 15 de cada producto
                                producto1.carritobot.Add(producto1.productossimulacion[producto].nombre);
                                producto1.carritobot.Add(producto1.productossimulacion[producto].marca);
                                producto1.carritobot.Add(Convert.ToString(cantidad));
                                producto1.productossimulacion[producto].cantidad -=cantidad ;
                                producto1.carritobot.Add(Convert.ToString(producto1.productossimulacion[producto].precio));
                            }
                            Console.WriteLine("yo " + trabajador0.empleadosauto[cajero].nombre + " " + trabajador0.empleadosauto[cajero].apellido + " lo atendere como su cajero el dia de hoy, veamos que es lo que trae...");
                            Console.WriteLine("Tome aqui esta su boleta");
                            Console.WriteLine("");
                            for (int Q = 0; Q < producto1.carritobot.LongCount(); Q+=4)
                            {
                                Console.WriteLine("Producto: " + producto1.carritobot[Q] +" Marca: "+producto1.carritobot[Q+1]+ ", Cantidad " + producto1.carritobot[Q+2] + ", Precio individual: " + producto1.carritobot[Q+3]);
                                
                            }            
                            Console.WriteLine("el total de su compra fue " + producto1.Sumacarritobot() + " " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Gracias por comprar, " + persona1.bots[bot].nombre + " " + persona1.bots[bot].apellido);
                            Console.WriteLine("Atendido por: " + trabajador0.empleadosauto[cajero].nombre + " " + trabajador0.empleadosauto[cajero].apellido);
                            producto1.carritobot.Clear();
                            Console.WriteLine("");


                                Console.WriteLine("");

                            }
                            for (int p = 0; p < producto1.productossimulacion.LongCount(); p++)
                            {
                                Console.WriteLine(producto1.productossimulacion[p].Informacion());
                            }
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





