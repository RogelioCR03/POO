using System;
using System.Collections.Generic;

namespace Actores
{
    class Peliculas
    {
       public string nombre;
       public void imprime()
       {
           Console.WriteLine(nombre);
       } 
       public Peliculas(string p)
       {
           nombre = p;
       }

        public string actor;
        public void imprimeActores()
        {
            Console.WriteLine(actor);
        }
        public AgregaActor(string a)
        {
            actor = a;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Peliculas> pelicula = new List<Peliculas>();
            List<AgregaActor> actores = new List<AgregaActor>();
            pelicula.Add(new Peliculas("Avengers"));
            actores.add(new AgregaActor("Robert Dawney JR"));
            actores [0].imprime();

            foreach (Peliculas a in pelicula)
            a.imprime();
        }
    }
}
