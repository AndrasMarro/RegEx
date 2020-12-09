using System;
using System.IO;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("daten.txt"))
            {
                string zeile;
                while((zeile=reader.ReadLine()) != null)
                {
                    
                }
            }

            Console.ReadKey();
        }
    }
}
