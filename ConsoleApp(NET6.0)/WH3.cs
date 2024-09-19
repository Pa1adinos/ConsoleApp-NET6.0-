using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class WH3
    {
        public static void Start()
        {
            int a = 10;
            double b = Convert.ToDouble(a);
            Console.WriteLine($"{b:N2}");
            string str = "25";
            int c = Convert.ToInt32(str);
            Console.WriteLine($"{c}");
            double d = 5.75;
            int e = Convert.ToInt32(d);
            Console.WriteLine($"{e}");
        }
    }
}
