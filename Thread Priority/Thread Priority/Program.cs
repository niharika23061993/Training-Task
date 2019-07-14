using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Priority
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Current Thread Informations**************n");
            Thread t = Thread.CurrentThread;
            t.Name = "Primary_Thread";

            Console.WriteLine("Thread Name: {0}", t.Name);
            Console.WriteLine("Thread Status: {0}", t.IsAlive);
            Console.WriteLine("Priority: {0}", t.Priority);

            Console.ReadKey();
        }
    }
}
