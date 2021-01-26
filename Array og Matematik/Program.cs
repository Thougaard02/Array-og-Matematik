using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_og_Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opg A");
            int[] listeB = new int[11];
            for (int i = 0, even = 0; i < listeB.Length; i++, even += 2)
            {
                listeB[i] = even;
                if (listeB[i] % 3 != 0)
                {
                    Console.WriteLine(listeB[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Opg B");
            listeB[2] = 17;

            for (int i = 0, even = 0; i < listeB.Length; i++, even += 2)
            {
                listeB[i] = even;
                if (listeB[i] % 3 == 0)
                {
                    Console.WriteLine(listeB[i]);
                }
            }

        }
    }
}
