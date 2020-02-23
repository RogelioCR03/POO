using System;
using System.Collections.Generic;

namespace Lista
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Peliculas> pelicula = new List<Peliculas>();
            pelicula.Add(new Peliculas("Avengers"));
            pelicula.Add(new Peliculas("Joker"));
            pelicula.Add(new Peliculas("Rapidos y Furiosos"));
            pelicula.Add(new Peliculas("Jurassic World"));
            pelicula.Add(new Peliculas("Toy Story"));

            foreach (Peliculas a in pelicula)
            a.imprime();
        }
    }
}
