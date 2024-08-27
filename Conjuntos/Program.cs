using Conjuntos.Entities;
using System.Collections.Generic;
using System.IO;

namespace Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> set = new HashSet<LogRecords> ();

            Console.WriteLine("Enter file for name path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecords { UserName =  name, Instant = instant });
                        Console.WriteLine(line);
                    }
                Console.WriteLine("Total Users: " + set.Count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

