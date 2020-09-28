using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ord_burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam = 8;
            int [] vec = new int [tam];

            Random x = new Random();
            int a = 0;
            while (a <= tam-1)
            {
                vec[a] = x.Next(1,11);
                Console.WriteLine(vec[a]);
                a++;
            }
            
            int temp = 0;
            for (int i = 1; i <=tam-1; i++)
            {
                for (int h = tam-1; h >= 1; h--)
                {
                    if (vec[h] > vec[h-1])
                    {
                        temp = vec[h -1];
                        vec[h -1] = vec[h];
                        vec[h] = temp;
                    }
                }
            }
            Console.WriteLine("ordenado");
            a = 0;
            while (a<=tam-1)
            {
                Console.WriteLine(vec[a]);
                a++;
            }
            Console.ReadKey();

        }
    }
}
