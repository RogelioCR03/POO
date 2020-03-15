using System;

namespace Parametros
{
    class Duplicador
    {
        public void duplica(int n) 
        //Aqui llega el valor que asignamos a X en la class Program, lo modifica pero antes de imprimirlo, regresa al numero normal al no estar asignada una referencia
        {
            n=n*2;
        }
        public void duplica_ref(ref int n)
        // Aqui llega el valor que le asignamos a Y, este si se modifica al estas puesta la referencia
        {
            n=n*2;
        }

        public void duplica_in(in int n)
        //Aqui llega el valor que le asignamos a Z, pero no se modifica porque esa es la funcion de in
        {
            int z =n*2;
        }

        public static void duplica_out(in int a, in int b, out int c)
        {
            c=a*b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duplicador d = new Duplicador(); 
            //Asignamos que crearemos un objeto tipo duplicador (el nombre de nuestra clase)

            int x = 41;
            int y = 87;
            int z = 27;
            int a = 142; int b = 2; int c;
            
            d.duplica(x); 
            //Aqui mandamos un valor al argumento duplica

            Console.WriteLine("Resultado sin usar parametro: " + x);
            //Al imprimirlo queda igual porque no esta puesto el comando ref y lo que imprime es el valor inicial

            d.duplica_ref(ref y);
            //Aqui mandamos un valor al argumento duplica_ref

            Console.WriteLine("Resultado usando parametro tipo ref: "+ y);
            //Si se modifica porque esta puesto como referencia

            d.duplica_in(in z);
            //Aqui mandamos un valor al metodo duplica_in

            Console.WriteLine("Resultado usando parametro tipo in: " + z);
            //Al imprimirlo nos regresa el valor de origen ya que esa es la funcion de in, querer utilizar un valor sin modificarlo en caso de que tengamos un metodo que use el mismo

            Duplicador.duplica_out(in a, in b, out c);
            //Aqui mandamos los datos propuestos en la class Program al metodo duplica_out para que haga la operacion propuesta

            Console.WriteLine("Resultado usando parametro tipo out: " + c);
            //Aqui imprime solo el resultado de la operacion
        }
    }
}
