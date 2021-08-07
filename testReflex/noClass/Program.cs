using System;

namespace noClass
{
    class TmpClass
    {
        public int x;
        public int y;

        public TmpClass(int x,int y)
        {
            this.x=x;
            this.y=y;
        }
        public int sum()
        {
            return x+y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
