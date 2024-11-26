using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Schleife
    {
        public static void Start1()
        {
            int counter = 1;
            for (int i = 0, j = 4; i < 4; i++, j--)
            {
                string row = "";
                while (row.Length < j-1)
                {  row = row + " "; }
                Console.Write(row);
                for (int k = 0 ; k <= i ; k++)
                { Console.Write(counter.ToString() + " "); counter++;}
                Console.WriteLine();
            }
        }
    }
}
