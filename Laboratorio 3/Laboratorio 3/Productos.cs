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
        //listas para el bonus

        private List<string> Nombreprodu = new List<string> { "Manjar kilo", "Kilo de pan", "Zapatillas talla 42", "Zapatillas talla 40", "Zapatos de cuero", "Paracaidas", "Nintendo Twich", "Station of play", "Ybox 360", "Figura de goku 30 cm", "Revista Super nintendo", "Peluche pikachu", "Soldados de juguete", "Pelota anti-estres", "Galletas obleas", "Galletas de limon", "Kilo de arroz", "Quimera de peluche", "Cubre camas", "jeans azules", "Anteojos de sol", "Doditos", "Ramamitas", "jugo en polvo", "jugo natural", "mascarillas", "kilo de peras", "revista condorito", "Juego pokemonos", "Juego Digimonos", "Peluche agumon", "Juego Guilty Gear", "Casa de princesas", "Papel higenico", "Papel tamaño carta", "Papel tamaño oficio", "Pantuflas talla 40", "Alfombra", "Poleron rojo", "Poleron azul", "Poleron amarillo" };
        public List<string> nombreprodu
        {
            get => Nombreprodu;
            set => Nombreprodu = nombreprodu;
        }
        private List<string> Marcaprodu = new List<string> {"Nestle", "Urban", "Guugle", "Soni", "Fairy", "Royal", "Hellow Kitti", "Amazonas", "Disney", "Yamahaha"};//10
        public List<string> marcaprodu
        {
            get => Marcaprodu;
            set => Marcaprodu = marcaprodu;
        }
        private List<int> Precioprodu = new List<int> {10,20,30,50,25,43,100,85,34,99 };//10 
        public List<int> precioprodu
        {
            get => Precioprodu;
            set => Precioprodu = precioprodu;
        }
        private List<int> Stocksprodu = new List<int> { 100, 120, 150, 180, 200, 250, 300, 80 };// 8 en total
        public List<int> stockprodu
        {
            get => Stocksprodu;
            set => Stocksprodu = stockprodu;
        }
        private List<Productos> Productossimulacion = new List<Productos>();
        public List<Productos> productossimulacion
        {
            get => Productossimulacion;
            set => Productossimulacion = productossimulacion;
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
        private string Marca;
        public string marca
        {
            get => Marca;
            set
            {
                Marca = marca;
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
        public Productos(string name, int stock, int price, string marca )
{
            Nombre = name;
            Cantidad = stock;
            Precio = price;
            Marca = marca;
}

        public Productos()
{

}



        public string Informacion()
        {

            return   "Producto: " + Nombre  +", Precio "+ Precio+ ", Stock disponible "+ Cantidad+", Marca:"+ Marca;
            

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
