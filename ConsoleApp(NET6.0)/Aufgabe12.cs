using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe12
    {
        public static void Start()
        {
            int[] intArray = new int[4] {70,30,89,13};
            // 1
            intArray[2] = 110;
            // 2
            intArray[3] += 17;
            // 3
            for (int i = 0; i < 4; i++) {intArray[i] /= 5;}
            // 4
            intArray = intArray.Concat(new int[2] {200, 500}).ToArray(); // Array.Resize(ref intArray, 6); intArray[4] =  200; intArray[5] = 500;
            // 5
            for (int i = 0; i < intArray.Length; i++) {intArray[i] *= 2;}
            // 6
            string[] str = { "Erstes", "Zweites", "Drittes", "Viertes", "Fünftes", "Sechstes" };
            for (int i = 0; i < intArray.Length; i++) {Console.WriteLine($"{str[i]} Element: {intArray[i]}");}
        }
    }
}
