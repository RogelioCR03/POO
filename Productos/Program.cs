using System;
using System.Collections.Generic;
using System.IO;

namespace Productos
{
    class Producto
    {
        public Producto (string n, string d, int dep, string c, int l , double p)
        {
            nombre = n;
            descripcion = d;
            departamento = dep;
            codigo = c;
            likes = l;
            precio = p;
            
        }
        public Producto()
        {

        }
        public string nombre {get; set;}
        public string codigo {get; set;}
        public string descripcion {get; set;}
        public int departamento {get; set;}
        public int likes {get; set;}
        public double precio;
       
    }
    
    /*class PrecioFecha
    {
        public List <PrecioFecha> Precios;
        DateTime FechaInicio;
        DateTime FechaFinal;
        Decimal Precio;

        public PrecioFecha(DateTime FI, DateTime FF, Decimal p)
        {
            FechaInicio = FI;
            FechaFinal = FF;
            Precio = p;

            Precios = new List<PrecioFecha>();
        }

        public DateTime getFechaInicio()
        {
            return FechaInicio;
        }

        public DateTime getFechaFinal()
        {
            return FechaFinal;
        }

        public Decimal getPrecio()
        {
            return Precio;
        }

        public void AgregarPrecio(PrecioFecha p)
        {
            Precios.Add(p);
        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}", DateTime.)
        }
    }*/
    
    class Program
    {
        static void Main(string[] args)
        {
            List <Producto> Productos = new List<Producto>();
            Productos.Add(new Producto("Balon", "Balon Nike del numero 5", 6, "SAHF5121", 89, 109.99));
            Productos.Add(new Producto("Agua natural", "Agua embotellada Bonafont", 9, "IENA7123", 14, 9.99));
            Productos.Add(new Producto("Cargador SAMSUNG", "Cargador carga rapida", 15, "GARQ1079", 57, 79.99));
            Productos.Add(new Producto("Cera AquaNet", "Cera para cabello", 3, "GQEH3798", 47, 39.99));
            Productos.Add(new Producto("Sartenes T-FAL", "Bateria de cocina", 2, "PQNF3798", 81, 1889.99));
            Productos.Add(new Producto("Guantes ADIDAS", "Guantes de portero", 6, "SAHF7897", 57, 169.99));
            Productos.Add(new Producto("Audifonos SKULLCANDY", "Audifonos inalambricos", 15, "PQUE1097", 107, 249.99));
            Productos.Add(new Producto("Coca-Cola", "Refresco de cola", 9, "IENA1489", 38, 14.99));
            Productos.Add(new Producto("Crema Pond's", "Crema para la piel", 3, "GQEH3478", 28, 59.99));
            Productos.Add(new Producto("Cuchillos Cuisinart", "Juego de cuchillos para cocina", 2, "PQNF7813", 53, 349.99));


            foreach (Producto p in Productos)
            Console.WriteLine("{0} | {1} | Departamento: {2} | Codigo: {3} | Likes: {4} | Precio: {5}", p.nombre, p.descripcion, p.departamento, p.codigo, p.likes, p.precio);
        
        }
    }
}
