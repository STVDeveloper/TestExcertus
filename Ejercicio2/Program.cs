using System;

namespace Ejercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Casos de uso ==> ");
            int T = Convert.ToInt32(Console.ReadLine());
            if (T >= 0 && T <= 100)
            {
                for (int i = 1; i <= T; i++)
                {
                    Console.Write("Tamaño de grupo a y Grupo B para caso " + i + " ==> ");
                    var caso = Console.ReadLine();
                    var arreglo1 = caso.Split(' ');

                    int ninosA = Convert.ToInt32(arreglo1[0]);
                    int ninosB = Convert.ToInt32(arreglo1[1]);
                    int toalNinosporGrupo = MaximoComunDivior(ninosA, ninosB);
                    Console.WriteLine("");
                    int totalequiposgrupoA = ninosA / toalNinosporGrupo;
                    int totalequiposgrupoB = ninosB / toalNinosporGrupo;
                    Console.WriteLine("Tamaño maximo de equipos " + toalNinosporGrupo + " total de coincidencias  " + (totalequiposgrupoA * totalequiposgrupoB));
                }
            }
            else
            {
                Console.WriteLine();
                Console.Write("Casos de uso debe ser un valor entre 0 y 100");
            }
            Console.ReadLine();
        }

        public static int MaximoComunDivior(int numero1, int numero2)
        {

            int mcd = 0;
            int a = Math.Max(numero1, numero2);
            int b = Math.Min(numero1, numero2);

            do
            {
                mcd = b;
                b = a % b;
                a = mcd;

            } while (b != 0);
            return mcd;
        }

    }
}
