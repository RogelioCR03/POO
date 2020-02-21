using System;

namespace Peliculas
{
    class pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

        public pelicula(string t)
        {
            titulo=t;
        }
        public string SetTitulo()
        {
            return titulo;
        }
        public int SetAño()
        {
            return año;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            pelicula p1 = new pelicula();
            p1.SetTitulo("Gravity");
            p1.SetAño("2013";
                      
            pelicula p2 = new pelicula();
            p1.SetTitulo("The Hurt Locker");
            p1.SetAño("2009");
        }
            
    }
}
