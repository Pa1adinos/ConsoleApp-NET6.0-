using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_NET6._0_
{
    internal class SQL_generator
    {
        public static void Start()
        {
            Random rnd = new Random();
            string filePath = @"C:\Users\Anatolij.Imgrund\Desktop\sql.txt";
            string[] ausgabe_arr = new string[100000];
            string[] name = { "Anna", "Max", "Lena", "Paul", "Emma", "Leon", "Mia", "Felix", "Sophia", "Tim", "Hannah", "Jonas", "Marie", "David", "Clara", "Noah", "Lukas", "Laura", "Ben", "Nina", "Jakob", "Sarah", "Tom", "Emily", "Christian", "Sophie", "Philip", "Lilly", "Moritz", "Julia", "Simon" };
            string[] vorname = { "Schmidt", "Müller", "Schneider", "Fischer", "Weber", "Mayer", "Becker", "Hoffmann", "Wagner", "Bauer", "Richter", "Koch", "Zimmermann", "Schulz", "Lange", "Schmitt", "Klein", "Wolf", "Zimmer", "Braun", "Jäger", "Hartmann", "Meier", "Löwe", "Schuster", "Bergmann", "Frank", "Peters", "Sauer", "Kraft", "Vogt" };
            string[] adr = { "Bahnhofstraße", "Hauptstraße", "Mühlweg", "Kirchweg", "Feldstraße", "Lindenstraße", "Bergstraße", "Dorfstraße", "Goethestraße", "Steinstraße", "Schulstraße", "Wilhelmstraße", "Parkstraße", "Gartenstraße", "Rosenweg", "Schillerstraße", "Eisenbahnstraße", "Freudenstraße", "Mozartstraße", "Heideweg", "Allee", "Sonnenstraße", "Marienstraße", "Seestraße", "Tannenweg", "Hafenstraße", "Neustraße", "Bismarckstraße", "Kastanienweg", "Bahnhofstraße", "Waldstraße" };
            string[] ort = { "Berlin", "München", "Hamburg", "Köln", "Frankfurt", "Stuttgart", "Düsseldorf", "Leipzig", "Dresden", "Hannover", "Nürnberg", "Bremen", "Erfurt", "Rostock", "Mannheim", "Würzburg", "Aachen", "Freiburg", "Heidelberg", "Regensburg", "Kassel", "Karlsruhe", "Bonn", "Lübeck", "Magdeburg", "Göttingen", "Augsburg", "Mainz", "Wiesbaden", "Siegen", "Chemnitz" };
            for (int i = 0; i < 100000; i++)
            {
                ausgabe_arr[i] = $"({i + 1}, '{name[rnd.Next(name.Length)]}', '{vorname[rnd.Next(vorname.Length)]}', '{adr[rnd.Next(adr.Length)]} {rnd.Next(1, 100)}', {rnd.Next(10000, 99999)}, '{ort[rnd.Next(ort.Length)]}'),";
            }
            File.WriteAllLines(filePath, ausgabe_arr);
        }
    }
}
