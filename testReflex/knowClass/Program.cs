using System;
using System.Reflection;
//using System.Reflection.Emit;

namespace testReflex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                利用类Assembly 根据程序集（没有预先知道类名等信息情况），利用xx.dll文件获取类的相关信息
            */
            //加载指定的程序集
            Assembly asm = Assembly.LoadFrom(@"C:\sioux_rl\Sioux\work\C#_test\testReflex\noClass\bin\Debug\netcoreapp3.1\noClass.dll");

            Console.WriteLine("************ 类 **************");
            Type[] ts = asm.GetTypes();
            foreach(Type t in ts)
            {
                Console.WriteLine(t.Name);
                
            }

            Type t_tmp = asm.GetType("noClass.TmpClass");
            Console.WriteLine(t_tmp.Name);
            object[] tmp_args = new object[2];
            tmp_args[0] = 10;
            tmp_args[1] = 20;

            object o_tmp = Activator.CreateInstance(t_tmp,10,20);
            MethodInfo mi = t_tmp.GetMethod("sum");
            Console.WriteLine(mi.Invoke(o_tmp,null));


            /*
                通过反射机制，获取类的方法
            */
            // Type t = typeof(TestClass);
            // Console.WriteLine("************ "+t.Name+" ****************");
            // MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly|BindingFlags.Public|BindingFlags.Instance); //获取所有方法 (其中会包含一些object的共有静态方法，因为C#所有类都继承了object类)
            //                                   // 利用 BindingFlags 获取特定方法
            // foreach(MethodInfo m in mi)
            // {
            //     //获取每一个方法的相关信息
            //     Console.Write(m.ReturnType.Name);
            //     Console.Write(" "+m.Name+"(");

            //     //parameters
            //     ParameterInfo[] pi = m.GetParameters();
            //     for(int i=0; i<pi.Length;++i)
            //     {
            //         Console.Write(pi[i].ParameterType.Name);
            //         Console.Write(pi[i].Name);
            //         if(i+1<pi.Length)
            //         {
            //             Console.Write(",");
            //         }
            //     }

            //     Console.Write(")");
            //     Console.WriteLine();
            // }

            /*
                通过反射调用类的方法
            */
            // Console.WriteLine("****************** 通过反射调用方法 *********************");

            // //调用两个参数的构造函数，实例化
            // Type r_t = typeof(TestClass);
            
            // //利用Activator.CreateInstance(TypePbject,参数)
            // Object o_construct = Activator.CreateInstance(r_t,100,300);
            // MethodInfo mi_sum = r_t.GetMethod("sum");
            // int val = (int)mi_sum.Invoke(o_construct,null);
            // Console.WriteLine("(Activator)sum: "+ val);

            // //传统方法，利用字符串和参数的比较获取相应的方法
            // ConstructorInfo[] ci = r_t.GetConstructors();
            
            // int k=0;
            // for(;k<ci.Length;++k)
            // {
            //     ParameterInfo[] r_pi = ci[k].GetParameters();
            //     if(r_pi.Length == 2)
            //     {
            //         break;
            //     }
            // }

            // if(k == ci.Length)
            // {
            //     return;
            // }

            // object[] conArgs = new object[2];
            // conArgs[0] = 100;
            // conArgs[1] = 300;
            // object reflexObject = ci[k].Invoke(conArgs); //构造函数若没有参数，则为Null

            // //利用实例化对象调用函数
            // MethodInfo[] r_mi = r_t.GetMethods(BindingFlags.DeclaredOnly|BindingFlags.Instance|BindingFlags.Public);
            // foreach(MethodInfo r_m in r_mi)
            // {
            //     if(r_m.Name.Equals("sum",StringComparison.Ordinal))
            //     {
            //         int sum = (int)r_m.Invoke(reflexObject,null); //如果是静态方法，则第一个参数为Null,而非类的对象
            //         Console.WriteLine("sum : "+ sum);
            //     }
            // }

            /*
                test 'is' 'as' 'typeof'
            */
            // TestClass tc1 = new TestClass();
            // A a = new A();

            // if (tc1 is TestClass)
            // {
            //     Console.WriteLine("tc1 belongs to TestClass");
            // }
            // else
            // {
            //     Console.WriteLine("tc1 doesn't belong to TestClass");
            // }

            // Type t = typeof(TestClass);

            // Console.WriteLine(t.FullName);
            // if(t.IsClass)
            // {
            //     Console.WriteLine("It is a class");
            // }
            // else
            // {
            //     Console.WriteLine("It's not a class");
            // }
        }
    }
}
