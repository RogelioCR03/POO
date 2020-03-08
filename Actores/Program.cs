using System;
using System.Collections.Generic;

namespace Actores
{
    class actor
    {
        private string act;
        private Int16 añoa;
        public actor(string a, Int16 p)
        {
            act = a;
            añoa = p;
        }
        public string getActor()
        {
            return act;
        }
        public Int16 getAñoa()
        {
            return añoa;
        }
    }
    class Peliculas
    {
       private string nombre;
       private Int16 año;
       private List<actor> actores;
       public Peliculas(string nombre, Int16 año)
       {
           this.nombre=nombre;
           this.año=año;
           actores = new List <actor>();
       }

       public string getPelicula()
       {
           return nombre;
       }
       public int getAñoP()
       {
           return año;
       }
       public void AgregaActor(actor a)
       {
           actores.Add(a);
       }
       public void ImprimeActores()
       {
           Console.WriteLine("La pelicula " + "{0}" + " fue estrenada en el año " + "{1}", nombre,año);
           foreach (actor a in actores){
               Console.WriteLine("En papel principal fue interpretado por " + "{0}" + " nacido(a) en el año " + "{1}", a.getActor(), a.getAñoa());
           }
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas p1 = new Peliculas ("Avengers", 2012);
            p1.AgregaActor(new actor ("Robert Dawney JR", 1965));
            p1.ImprimeActores();
            Peliculas p2 = new Peliculas ("Joker", 2019);
            p2.AgregaActor(new actor ("Joaquin Phoenix", 1974));
            p2.ImprimeActores();
            Peliculas p3 = new Peliculas ("Rapido y Furioso", 2009);
            p3.AgregaActor(new actor ("Vin Diesel", 1967));
            p3.ImprimeActores();
            Peliculas p4 = new Peliculas ("Jurassic World", 2015);
            p4.AgregaActor(new actor ("Chris Pratt", 1979));
            p4.ImprimeActores();
            Peliculas p5 = new Peliculas ("King Kong", 2005);
            p5.AgregaActor(new actor ("Naomi Watts", 1968));
            p5.ImprimeActores();

        }
    }
}
