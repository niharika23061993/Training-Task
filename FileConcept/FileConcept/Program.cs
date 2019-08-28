using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;

            data = File.ReadAllText("C:\\Task\\ABC.txt");
            Console.WriteLine("Content of ABC.TXT :\n" + data);
            Console.ReadLine();

            File.Copy("C:\\Task\\ABC.txt", "C:\\Task\\XYZ.txt");

            data = File.ReadAllText("C:\\Task\\XYZ.txt");
            Console.WriteLine("Content of XYZ.TXT :\n" + data);
            Console.ReadLine();

        }
    }
}
