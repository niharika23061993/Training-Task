using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_pool
{
    class ThreadPoolDemo
    {
       
            public void task1(object obj)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Task 1 is being executed");
                }
            }
            public void task2(object obj)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Task 2 is being executed");
                }
            }

            static void Main()
            {
                ThreadPoolDemo tpd = new ThreadPoolDemo();
                for (int i = 0; i < 2; i++)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
                }

                Console.Read();
            }
        
    }
}
