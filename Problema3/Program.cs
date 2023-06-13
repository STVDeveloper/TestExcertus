using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> estudiantes = new List<string>();
            List<string> personal = new List<string>();
            List<string> profesor = new List<string>();
            bool esentrada = true;
            int tipovisitante = 1;

            Console.Write("Casos de uso ==> ");
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                Console.Write("Ingresar persona para caso " + i + " ==> ");
                string persona = Console.ReadLine();
                if (tipovisitante == 1)
                {
                    if (esentrada)
                    {
                        if (estudiantes.Where(x => x.ToString().Equals(persona)).ToList().Count > 0)
                            Console.WriteLine("NO");
                        else
                        {
                            estudiantes.Add(persona);
                            Console.WriteLine("YES");
                        }
                        esentrada = false;
                    } else
                    {
                        if (estudiantes.Where(x => x.ToString().Equals(persona)).ToList().Count == 1)
                        {
                           estudiantes.Remove(persona);
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                        esentrada = true;
                        tipovisitante = 2;
                    }
                } else if (tipovisitante == 2)
                {
                    if (esentrada)
                    {
                        if (personal.Where(x => x.ToString().Equals(persona)).ToList().Count > 0)
                            Console.WriteLine("NO");
                        else
                        {
                            personal.Add(persona);
                            Console.WriteLine("YES");
                        }
                        esentrada = false;
                    }
                    else
                    {
                        if (personal.Where(x => x.ToString().Equals(persona)).ToList().Count == 1)
                        {
                            personal.Remove(persona);
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                        esentrada = true;
                        tipovisitante = 3;
                    }

                }
                else if (tipovisitante == 3)
                {
                    if (esentrada)
                    {
                        if (profesor.Where(x => x.ToString().Equals(persona)).ToList().Count > 0)
                            Console.WriteLine("NO");
                        else
                        {
                            profesor.Add(persona);
                            Console.WriteLine("YES");
                        }
                        esentrada = false;
                    }
                    else
                    {
                        if (profesor.Where(x => x.ToString().Equals(persona)).ToList().Count == 1)
                        {
                            profesor.Remove(persona);
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                        esentrada = true;
                        tipovisitante = 1;
                    }

                }
            }
        }       
    }
}
