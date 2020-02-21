using System;

namespace Peliculas
{
    class pelicula
    {
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;

        public pelicula(string titulo, Int16 año)
        {
            this.titulo=titulo;
            this.año=año;
        }
        public void imprime()
        {
            Console.WriteLine("{0} {1}  ",titulo,año);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            pelicula p1 = new pelicula("Gravity",2013);
            p1.imprime();

            pelicula p2 = new pelicula("Joker",2019);
            p2.imprime();

                
        }
            
    }
}
