using System;
using System.Collections.Generic;

namespace Actores
{
    class Peliculas
    {
       public string nombre;
       public Int16 añop;
       public void imprime()
       {
           Console.WriteLine("{0} {1}", nombre,añop);
       } 
       public Peliculas(string p, Int16 a)
       {
           nombre = p;
           añop = a;

       }
    }

    class actores 
    {
        private string actor;
        private Int16 año;

        public actores (string actor, Int16 año)
        {
            this.actor=actor;
            this.año=año;
        }
        public void imprimeActores()
        {
            Console.WriteLine("{0} {1}",actor,año);
        }
        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Peliculas> pelicula = new List<Peliculas>();
            pelicula.Add(new Peliculas("Avengers", 2012));
            actores a1 = new actores("Robert Dawney Jr", 1965);



            foreach (Peliculas a in pelicula)
            a.imprime();
            a1.imprimeActores();
        }
    }
}
