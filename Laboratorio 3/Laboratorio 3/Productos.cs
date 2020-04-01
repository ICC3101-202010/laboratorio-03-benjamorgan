﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    //listas y partes del objeto
    class Productos
    {
        private List<Productos> Carrito = new List<Productos>();
        public List<Productos> carrito
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
        private string Nombre;
        public string nombre
{
            get => Nombre;
            set
            {
                nombre = Nombre;
            }
}

        private int Cantidad;
        public int cantidad
{
            get => Cantidad;
            set
            {
                cantidad = Cantidad;
            }
}

        private int Precio;
        public int precio
{
            get => Precio;
            set
            {
                precio = Precio;
            }
}

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




    }
}