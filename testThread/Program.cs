using System;
using System.Threading;

namespace testThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(fun1));
            th1.Start();

            Thread th2 = new Thread(new ThreadStart(fun2));
            th2.Start();

            while(true)
            {
                Thread.Sleep(3000);
                Console.WriteLine("th1: "+th1.IsAlive+"    "+"th2: "+th2.IsAlive);
                // Console.WriteLine("th2: "+th2.IsAlive);
            }
        }

        public static void fun1()
        {
            try
            {
                for(int i=0;i<50;++i)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("First thread 1 work:"+ i.ToString());
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
                Thread.ResetAbort();
            }  
        }

        public static void fun2()
        {
            try
            {
                for(int i=0;i<50;++i)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Second thread 2 work:"+ i.ToString());
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
                Thread.ResetAbort();
            } 
        }
    }
}
