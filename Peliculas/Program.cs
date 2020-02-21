using System;
using System.Collections.Generic;

namespace Peliculas
{
    class pelicula
    {
        public string titulo;
        public int año;
        public string pais;
        public string director;
        public void imprime()
        {
            Console.WriteLine(titulo,año,pais,director);
        }
        public pelicula (string n,int a, string p,string d)
        {
            titulo=n;
            año=a;
            pais=p;
            director=d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<pelicula> oscars = new List<pelicula>();
            oscars.Add(new pelicula("Joker", 2019, "Estados Unidos", "Todd Phillips"));
           
            
            for(int i=0;i<oscars.Count;i++)
            oscars[i].imprime();
        }
    }
}
