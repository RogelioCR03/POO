using System;

namespace Domino
{
    class Domino
    {
        public int arriba;
        public int abajo;
        public int total;

        public Domino(int arr, int aba)
        {
            arriba = arr;
            abajo = aba;
            total = arriba + abajo;
        }

        public override string ToString()
        {
            return String.Format("{0}|{1}" + " La suma de esta ficha da " + "{2}", arriba, abajo, total);
        }

        public static Domino operator + (Domino x, Domino y)
        {
            int arriba = (x.arriba + y.arriba);
            int abajo = (x.abajo + y.abajo);
    
            return new Domino(arriba,abajo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino a = new Domino (5,6);
            Domino b = new Domino (4,3);

            Domino c = a+b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("El numero de puntitos resultantes es " + c);

        }
    }
}