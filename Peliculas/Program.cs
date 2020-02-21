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
            
        }
            
    }
}
