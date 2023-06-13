using System;

namespace Problema4
{
    public  class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Casos de uso ==> ");
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                Console.Write("total de Cubos para caso " + i + " ==> ");
                var totalCubosCaso = Console.ReadLine();
                while (true)
                {
                    int totalCubos = Convert.ToInt32(totalCubosCaso);
                    if (totalCubos > 0 && totalCubos <= 500)
                    {
                        double raiz_cubica = Math.Pow(totalCubos, 1.0 / 3.0);
                        double costobase = Math.Ceiling(raiz_cubica);
                        Console.Write("Costo por envio " + (costobase + costobase + costobase));
                        Console.WriteLine();
                        break;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
