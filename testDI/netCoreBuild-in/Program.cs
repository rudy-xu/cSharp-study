using System;
using Microsoft.Extensions.DependencyInjection;

namespace testDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello .NET Core IOC!");

            var services = new ServiceCollection();
            services.AddSingleton<ITestSingle,TestSingle>();
            services.AddScoped<ITestScope,TestScope>();
            services.AddTransient<ITestTrans,TestTans>();

            ServiceProvider servProvider = services.BuildServiceProvider();

            var t_single = servProvider.GetService<ITestSingle>();
            t_single.Age=10;
            Console.WriteLine("IOC-Age: "+t_single.Age);

            TestSingle ts = new TestSingle();
            ts.Age = 100;
            Console.WriteLine("class-Age: "+t_single.Age);
        }
    }
}
