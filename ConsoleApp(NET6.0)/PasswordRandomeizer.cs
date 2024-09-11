using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class PasswordRandomeizer
    {
        public static void Start()
        {
            string kl_buchstaben = "a b c d e f g h i j k l m n o p q r s t u v w x y z",
                   gr_buchstaben = kl_buchstaben.ToUpper(),
                   zahlen = "0 1 2 3 4 5 6 7 8 9",
                   zeichen = "§ $ % & _ -",
                   pass_wahl = kl_buchstaben + gr_buchstaben + zahlen + zeichen,
                   password = "";

            string[] pass_array = pass_wahl.Split(" ");

            int arr_len = pass_array.Length;

            while (true)
            {
                Console.WriteLine("Die Passwordlänge eingeben:\n");
                int pass_len = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < pass_len; i++)
                {
                    int rand = new Random().Next(0, arr_len);
                    password += pass_array[rand];
                }

                Console.WriteLine(password + "\n");
                password = "";
            }
        }
    }
}
