using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class BobleSort
    {
        public static void Start()
        {
            Random rnd = new Random();
            int[] test_array = new int[100];
            for(int i = 0;  i < test_array.Length; i++)
                test_array[i] = rnd.Next(0, 1000);

            Console.WriteLine("Test Array vor der Sortieren:\n");
            foreach (int elem in test_array)
            {         
                Console.Write($"{elem} ");
            }

            int sort = 0;
            while (sort < test_array.Length)
            {
                for (int i = 0; i < test_array.Length - 1; i++)
                {
                    if (test_array[i] > test_array[i + 1])
                    {
                        int temp = test_array[i+1];
                        test_array[i+1] = test_array[i];
                        test_array[i] = temp;
                    }
                }
                sort++;
            }

            Console.WriteLine("\n\nTest Array nach der Sortieren:\n");
            Console.Write("Start - ");
            foreach (int elem in test_array)
            { 
                Console.Write($"{elem} <= ");
            }
            Console.WriteLine("Ende");
            Console.WriteLine();
        }
    }
}
