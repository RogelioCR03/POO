using System;

namespace Duracion
{
    class Duracion 
    {
        public int horas;
        public int minutos;
        public int segundos;

        public Duracion (int hor, int min, int seg)
        {
            horas = hor;
            minutos = min;
            segundos = seg;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}", horas, minutos, segundos);
        }

        public static Duracion operator +(Duracion x, Duracion y)
        {
            int horas = x.horas + y.horas;
            int minutos = x.minutos + y.minutos;
            int segundos = x.segundos + y.segundos;

            if (segundos > 60)
            {
                segundos = segundos - 60;
                minutos = minutos + 1;
            }

            if (minutos > 60)
            {
                minutos = minutos - 60;
                horas = horas + 1;
            }

            return new Duracion(horas, minutos, segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion a = new Duracion (2,37,49);
            Duracion b = new Duracion (1,58,53);

            Duracion c = a+b;

            Console.WriteLine("El tiempo 1 fue de: " + a);
            Console.WriteLine("El tiempo 2 fue de: " + b);
            Console.WriteLine("La suma de los tiempos es de: " + c);
        }
    }
}
