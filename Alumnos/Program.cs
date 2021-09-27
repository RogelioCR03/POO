using System;

namespace Distancia_de_punto_a_plano
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estos valores son ingresados por el usuario
            double x = 8;
            double y = -4;
            double z = 1;
            double producto = 8;

            Console.WriteLine("Vector n: <{0},{1},{2}>", x, y, z);

            double magnitud = (Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)); //Obtener la magnitud
            Console.WriteLine("Magnitud: √{0}", magnitud);

            double[] PuntoP = new double[3]; //Punto que se calcula con el valor de x del plano, los 0 son constantes
            PuntoP[0] = producto / x;
            PuntoP[1] = 0;
            PuntoP[2] = 0;

            double[] PuntoQ = new double[3]; //Punto que debe ser ingresado por el Usuario
            PuntoQ[0] = 0;
            PuntoQ[1] = 0;
            PuntoQ[2] = 0;

            double[] PQ = new double[3]; //Distancia del punto P al Q
            PQ[0] = (PuntoQ[0] - PuntoP[0]);
            PQ[1] = (PuntoQ[1] - PuntoP[1]);
            PQ[2] = (PuntoQ[2] - PuntoP[2]);

            Console.Write("PQ: ");
            foreach(var a in PQ) 
            {
                Console.Write("{0},",a);
            }

            double distancia = Math.Abs((PQ[0] * x) + (PQ[1] * y) + (PQ[2] * z)) / Math.Sqrt(magnitud);
            Console.WriteLine("\n {0}", distancia);


        }
    }
}
  
