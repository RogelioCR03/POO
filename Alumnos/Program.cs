using System;
 
namespace Herencia
{
    class Alumno
    {
        protected string nombre;
 
        public Alumno (string n)
        {
            nombre = n;
        }
 
        public virtual void actividad()
        {
            Console.WriteLine("Hola soy {0}", nombre);
        }
    }
 
    class Licenciatura : Alumno
    {
        protected string ServSocial;
 
        public Licenciatura(string nombre, string ServSocial):base(nombre)
        {
            this.ServSocial = ServSocial;
        }
        public new void actividad()
        {
            Console.WriteLine("Mi nombre es {0}, soy estudiante de licenciatura y mi servicio social es  {1}", nombre,ServSocial);
        }        
    }
        class Posgrado : Alumno
    {
        protected string tema;
 
        public Posgrado(string nombre, string tema):base(nombre)
        {
            this.tema = tema;
        }
        public new void actividad()
        {
            Console.WriteLine("Mi nombre es {0}, soy estudiante de posgrado y mi tema de investigacion es {1}", nombre,tema);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alumno Martin = new Alumno ("Martin");
            Licenciatura Rodrigo = new Licenciatura("Rodrigo","limpiar la escuela");
            Posgrado Axel = new Posgrado("Axel","contaminacion");

            Martin.actividad();
            Rodrigo.actividad();
            Axel.actividad();

        }
    }
}                    