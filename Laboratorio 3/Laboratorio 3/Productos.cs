using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    //listas y partes del objeto
    class Productos
    {
        private List<string> Carrito = new List<string>();
        public List<string> carrito
        {
            get => Carrito;
            set => Carrito = carrito;
        }
        private List<Productos> Todoslosproductos = new List<Productos>();
        public List<Productos> todoslosproductos
        {
            get => Todoslosproductos;
            set => Todoslosproductos = todoslosproductos;
        }
        private List<string> Todaslasboletas = new List<string>();
        public List<string> todaslasboletas
        {
            get => Todaslasboletas;
            set => Todaslasboletas = todaslasboletas;
        }
        private string Nombre;
        public string nombre
{
            get => Nombre;
            set
            {
                Nombre = nombre;
            }
}

        private int Cantidad;


        private int Precio;
        public int precio
{
            get => Precio;
            set
            {
                Precio = precio;
            }
}

        public int cantidad { get => Cantidad; set => Cantidad = value; }

        //constructor
        public Productos(string name, int stock, int price)
{
            Nombre = name;
            Cantidad = stock;
            Precio = price;
}

        public Productos()
{

}



        public string Informacion()
        {

            return   "Producto: " + Nombre  +", Precio "+ Precio+ ", Stock disponible "+ Cantidad;
            

        }
        public int Sumacarrito()
        {
            int Suma = 0;
            for (int i = 2; i < carrito.LongCount(); i+=3)
            {
                Suma += (Convert.ToInt32(carrito[i]) * Convert.ToInt32(carrito[i-1]));
            }

            return Suma;


        }




    }
}
