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
            //2,4,5,8,10,11,14,16,17,19,20
            List<int> listeB = new List<int>();
            List<int> listeC = new List<int>();
            for (int i = 1; i < 21; i++)
            {
                listeB.Add(i);
            }
            listeB[3] = 17;
            for (int i = 1; i < listeB.Count; i++)
            {
                if (listeB[i] % 3 == 0)
                {
                    listeB.RemoveAt(i);
                }
                Console.WriteLine(listeB[i]);
            }
            Console.WriteLine("\nOpg B");
            listeB.Reverse();
            listeC = listeB;
            for (int i = 1; i < listeC.Count; i++)
            {
                Console.WriteLine(listeC[i]);
            }

        }
    }
}