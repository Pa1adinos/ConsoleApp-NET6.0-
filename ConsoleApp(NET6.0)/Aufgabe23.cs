using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class Aufgabe23
    {
        public static void Start()
        {
            string ausgabe = "Ihr String ist: ";
            Console.WriteLine("Bitte geben Sie Strings ein:");
            bool und = false;
            while (true)
            {
                string eingabe = Console.ReadLine();
                if (eingabe == "")
                { 
                    break;
                }
                if (und)
                {
                    ausgabe += " und ";
                }
                if (eingabe.Length < 6)
                {
                    ausgabe += eingabe;
                    und = true;
                    continue;
                }
                else if (eingabe.Length > 5)
                {
                    string temp = "";
                    for (int i = 0; i < eingabe.Length; i++)
                    {
                        if (!"aeiou".Contains(eingabe.ToLower()[i]))
                        {
                            temp += eingabe[i];
                        }
                    }
                    if (temp.Length > 5)
                    {
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (!"std".Contains(temp.ToLower()[i]))
                            {
                                ausgabe += temp[i];
                            }
                        }
                    }
                    else
                    {
                        ausgabe += temp;
                    }
                    und = true;
                }
            }
            Console.WriteLine(ausgabe);
        }
    }
}
