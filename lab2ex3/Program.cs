using System;
using System.Collections.Generic;

namespace lab2ex3
{
    /* Ex 3 Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatura. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatura. \n");

            var nr = 0;
            Console.WriteLine("Introduceti n (n - numar de cifere ale sirului) :");
            bool success = int.TryParse(Console.ReadLine(), out nr);

            var list = new List<Int32>();

            if (success)
            {
                var sum = 0;
                var counter = 0;

                try
                {
                    for (var i = 0; i < nr; i++)
                    {
                        Console.Write($"element - {i} : ");
                        var nrCitit = int.Parse(Console.ReadLine());
                        list.Add(nrCitit);

                        if(nrCitit % 2 == 0)
                        {
                            sum = sum + nrCitit;
                            counter++;
                        }
                    }

                    Console.WriteLine(" Sirul citit este: ");
                    foreach (var elem in list) Console.WriteLine(elem);

                    Console.WriteLine(" Media aritmetica a numerelor pare este: " + sum/counter);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception "+ ex);
                }
            }
            else
            {
                Console.WriteLine(" Atentie! Ai introdus si litere!");
            }
        }
    }
}
