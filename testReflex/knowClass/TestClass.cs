using System;

namespace testReflex
{
    class A{}
    class TestClass
    {
        public int x;
        public int y;

        public TestClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public TestClass() { }
        public TestClass(int x)
        {
            this.x = x;
            this.y = 9999;
        }

        public void set(int a, int b)
        {
            x = a;
            y = b;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int sum()
        {
            return x + y;
        }

        public void show()
        {
            Console.WriteLine("x:{0},y:{1}", x, y);
        }

    }
}