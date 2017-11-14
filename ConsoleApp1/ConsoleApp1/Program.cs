using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\Märkmed\";
            FileInfo[] Files = new DirectoryInfo(folder).GetFiles("*.txt");
            Console.WriteLine("Olemasolevad failid:");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }

            bool x = true;
            while (x == true)
            {
                string käsk = Console.ReadLine();
                if (käsk == "New")
                {
                    Console.WriteLine("Sisestage uue faili nimetus.");
                    string failNim = Console.ReadLine();
                    Console.WriteLine("Sisestage laused, mis lähevad faili.");
                    string failText = Console.ReadLine();
                    File.WriteAllText(folder + failNim + ".txt", failText);
                }
                else if (käsk == "Read")
                {
                    Console.WriteLine("Sisestage loetava faili nimetus.");
                    string failNim = Console.ReadLine();
                    bool olemas = File.Exists(folder + failNim + ".txt");
                    if (olemas == true)
                    {
                        string failText = File.ReadAllText(folder + failNim + ".txt");
                        Console.WriteLine(failText);
                    }
                    else
                    {
                        Console.WriteLine("Niisugust faili pole.");
                    }
                }
                else if (käsk == "Delete")
                {
                    Console.WriteLine("Sisestage kustutava faili nimetus.");
                    string failNim = Console.ReadLine();
                    bool olemas = File.Exists(folder + failNim + ".txt");
                    if (olemas == true)
                    {
                        Console.WriteLine("Kas te olete kindel, et taha seda faili kustutada? (Y/N)");
                        string conf = Console.ReadLine();
                        if (conf == "Y")
                        {
                            File.Delete(folder + failNim + ".txt");
                            Console.WriteLine("Fail on kustuatud");
                        }
                        else
                        {
                            Console.WriteLine("Niisugust faili pole");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Niisugust faili pole.");
                    }
                }
                else if (käsk == "Exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Te sisestasite vale käsu. Võimalikud käsud:");
                    Console.WriteLine("New - Uue faili koostamine ja märkemte kirjutamine sellesse.");
                    Console.WriteLine("Read - Faili lugemine.");
                    Console.WriteLine("Delete - Faili kustutamine.");
                    Console.WriteLine("Exit - Programmi sulgemine.");
                }
                Console.WriteLine("");
                Console.WriteLine("Kas soovite jätkata? (Y/N)");
                string ksSo = Console.ReadLine();
                if (ksSo == "Y")
                {
                    x = true;
                }
                else if (ksSo != "Y")
                {
                    x = false;
                }
            }
            Console.WriteLine("Programm lõpetas töö.");
        }
    }
}























