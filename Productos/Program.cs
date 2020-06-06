using System;
using System.Collections.Generic;
using System.IO;

namespace Productos
{
    class Producto : IComparable
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
        public int CompareTo(object obj)
        {
            return likes.CompareTo(((Producto)obj).likes);
        }
       public int Compare(object obj)
       {
           return departamento.CompareTo(((Producto)obj).departamento);
       }
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

    class ProductDB
    {
        public static void WriteToTXT(string path, List<Producto> Productos)
        {
            StreamWriter txtOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach(Producto p in Productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", p.nombre, p.descripcion, p.departamento, p.codigo, p.likes, p.precio);
            }
            txtOut.Close();
        }
        public static List<Producto> ReadFromTXT(string path)
        {
            List<Producto> Productos = new List<Producto>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while(txtIn.Peek()!= -1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Producto p = new Producto(columns[0],columns[1],Int32.Parse(columns[2]),columns[3],Int32.Parse(columns[4]),Double.Parse(columns[5]));
                Productos.Add(p);
            }
            return Productos;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            0Productos.Add(new Producto("Balon", "Balon Nike del numero 5", 6, "SAHF5121", 89, 109.99));
            1Productos.Add(new Producto("Agua natural", "Agua embotellada Bonafont", 9, "IENA7123", 14, 9.99));
            2Productos.Add(new Producto("Cargador SAMSUNG", "Cargador carga rapida", 15, "GARQ1079", 57, 79.99));
            3Productos.Add(new Producto("Cera AquaNet", "Cera para cabello", 3, "GQEH3798", 47, 39.99));
            4Productos.Add(new Producto("Sartenes T-FAL", "Bateria de cocina", 2, "PQNF3798", 81, 1889.99));
            5Productos.Add(new Producto("Guantes ADIDAS", "Guantes de portero", 6, "SAHF7897", 57, 169.99));
            6Productos.Add(new Producto("Audifonos SKULLCANDY", "Audifonos inalambricos", 15, "PQUE1097", 107, 249.99));
            7Productos.Add(new Producto("Coca-Cola", "Refresco de cola", 9, "IENA1489", 38, 14.99));
            8Productos.Add(new Producto("Crema Pond's", "Crema para la piel", 3, "GQEH3478", 28, 59.99));
            9Productos.Add(new Producto("Cuchillos Cuisinart", "Juego de cuchillos para cocina", 2, "PQNF7813", 53, 349.99));
            ProductDB.WriteToTXT("Listado.txt", Productos);
            */
            
            int instruccion;
            int departamento;

            Console.WriteLine("¿Que desea saber?");
            Console.WriteLine("1.- Lista de precios completa");
            Console.WriteLine("2.- Productos por departamento");
            Console.WriteLine("3.- Orden de likes");
            Console.WriteLine("Ingrese instruccion:");
            instruccion = Int32.Parse(Console.ReadLine());

            if (instruccion == 1)
            {
                List<Producto> Productos = new List<Producto>();
                Productos = ProductDB.ReadFromTXT(@".\Listado.txt");
                foreach(Producto p in Productos)
                Console.WriteLine("Producto: {0}|{1}|Dep: {2}|Codigo: {3}|Likes: {4}|Precio: {5}$", p.nombre, p.descripcion, p.departamento, p.codigo, p.likes, p.precio);
            }
            else if (instruccion == 2)
            {
                Console.WriteLine("¿De que departamentos desea productos?");
                Console.WriteLine("Departamento 2: Articulos para el hogar");
                Console.WriteLine("Departamento 3: Cosmeticos");
                Console.WriteLine("Departamento 6: Deportes");
                Console.WriteLine("Departamento 9: Alimentos y bebidas");
                Console.WriteLine("Departamento 15: Electronica");
                Console.WriteLine("Ingrese departamento");
                departamento = Int32.Parse(Console.ReadLine());
                if(departamento == 2)
                {
                    List<Producto> Productos = new List<Producto>();
                    Productos = ProductDB.ReadFromTXT(@".\Listado.txt");
                    Productos.RemoveRange(0,4);
                    Productos.RemoveRange(1,4);
                    foreach(Producto p in Productos)
                    Console.WriteLine("Producto: {0}|{1}|Dep: {2}|Codigo: {3}|Likes: {4}|Precio: {5}$", p.nombre, p.descripcion, p.departamento, p.codigo, p.likes, p.precio);
                }
                else if (departamento == 3)
                {
                    List<Producto> Productos = new List<Producto>();
                    Productos = ProductDB.ReadFromTXT(@".\Listado.txt");
                    Productos.Sort();
                    foreach(Producto p in Productos)
                    Console.WriteLine("Producto: {0}|{1}|Dep: {2}|Codigo: {3}|Likes: {4}|Precio: {5}$", p.nombre, p.descripcion, p.departamento, p.codigo, p.likes, p.precio);
                }
            }
            else if (instruccion == 3)
            {
                List<Producto> Productos = new List<Producto>();
                Productos = ProductDB.ReadFromTXT(@".\Listado.txt");
                Productos.Sort();
                Productos.Reverse();
                foreach(Producto p in Productos)
                Console.WriteLine("Producto: {1}|{2}|Dep: {3}|Codigo: {4}|Likes: {0}|Precio: {5}$", p.likes, p.nombre, p.descripcion, p.departamento, p.codigo, p.precio);
            }
        }
    }
}
