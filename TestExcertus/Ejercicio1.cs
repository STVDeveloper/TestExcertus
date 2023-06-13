using System;
using System.Linq;

namespace TestExcertus
{
    internal class Ejercicio1

    {
        static void Main(string[] args)
        {
            Console.Write("Casos de uso ==> ");
            int T = Convert.ToInt32(Console.ReadLine());
            if (T > 0 && T <= 100)
            {
                for (int i = 1; i <= T; i++)
                {
                    Console.Write("Tipos de dulces -- Minimo dulces para caso " + i + " ==> ");
                    var caso = Console.ReadLine();
                    var arreglo1 = caso.Split(' ');

                    int totalTipos = Convert.ToInt32(arreglo1[0]);
                    int minimoTipos = Convert.ToInt32(arreglo1[1]);
                    Console.Write("total de dulces para " + totalTipos + " tipos ==> ");
                    var listaToatlesTipos = Console.ReadLine();
                    string[] arreglo2 = listaToatlesTipos.Split(' ');
                    var numeros = arreglo2.Select(e =>
                    {
                        if (Convert.ToInt32(e) >= minimoTipos)
                            return Convert.ToInt32(e) / minimoTipos;
                        else
                            return 0;
                    }).ToList();
                    Console.WriteLine(numeros.Max());

                }
            }
            else
            {
                Console.WriteLine();
                Console.Write("Casos de uso debe ser un valor entre 1 y 100");
            }
            Console.ReadLine();
            ;
        }
    }
}
