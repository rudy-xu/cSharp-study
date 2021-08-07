using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace hello
{
    public struct Address
    {
        public string ip { set; get; }
        public string mac { set; get; }
    }

    public struct Msg
    {
        public string key { set;get; }
        public string key1 { set;get; }
    }
    public struct Data
    {
        public int id { set; get; }
        public string name { set; get;}
        public Address addr { set; get; }
        public List<Msg> lt { set;get; }
        public string remark { set; get; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string msg = "hello";
            string msg2 = msg.Trim('\'');
            Console.WriteLine(msg2);

            /*
                task random
            */
            // Random rd = new Random();
            // Console.WriteLine(rd.Next());

            // Myclass mc = new Myclass();

            // Console.WriteLine($"Hello World! {mc.getMessage()}");
        
            /*
                test Task
            */
            //-------async/await

            // Console.Out.Write("Start\n");
            // GetValueAsync();
            // Console.Out.Write("End\n");
            // Console.ReadKey();

            // static async void GetValueAsync()
            // {
            //     await Task.Run(()=>
            //     {
            //         Thread.Sleep(1000);
            //         for(int i = 0; i < 5; ++i)
            //         {
            //             Console.Out.WriteLine(String.Format("From task : {0}", i));
            //         }
            //     });

            //     Console.Out.WriteLine("Task End");
            // }


            //-------Task.RUn( () => xxx);
            // Console.WriteLine("main Thread: before for");

            // Task t = Task.Run(() => 
            //         {
            //             while (true)
            //             {
            //                 Console.WriteLine("-------------");
            //                 for(int i=0;i<5;++i){
            //                     Thread.Sleep(1000);
            //                     Console.WriteLine("i: "+i.ToString());
            //                 }
            //                 Console.WriteLine("****************");                    
            //             }
            //         } );

            // Console.WriteLine("main Thread: after for");    

            // t.Wait();  //或者使用 Console.ReadKey()；等待程序运行。

            // //-------- new Task( ()=>xxxx );
            // Console.WriteLine("main Thread: before for");

            // Task task = new Task( () => 
            // {
            //     Console.WriteLine("-------------");
            //     for(int i=0;i<5;++i){
            //         Thread.Sleep(1000);
            //         Console.WriteLine("i: "+i.ToString());
            //     }
            //     Console.WriteLine("****************");
            // } );

            // task.Start();

            // Console.WriteLine("main Thread: after for");

            // task.Wait();


            /*
                test string to json
            */
            // string jsonText = "{\"shenzheng\":\"深圳\",\"beijing\":\"北京\",\"shanghai\":[{\"zj1\":\"zj11\",\"zj2\":\"zj22\"},\"zjs\":\"nihao\"]}";

            // var jy = JsonConvert.DeserializeObject<dynamic>(jsonText);
            // Console.WriteLine(jy.shanghai);

            // // JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);
            // // Console.WriteLine(jo["shanghai"][0]["zj1"].ToString());

            /*
                test "Class to json"
            */

            // Msg m1 = new Msg{
            //     key="key",
            //     key1="key1"
            // };

            // Msg m2 = new Msg{
            //     key="m2Key",
            //     key1="m2Key2"
            // };
            // List<Msg> lm = new List<Msg>();
            // lm.Add(m1);
            // lm.Add(m2);

            // Address ad = new Address{
            //     ip="168.0.0.1",
            //     mac="AB:CD:00:SD:45:FF:AA:11"
            // };

            // Data data = new Data{
            //     id=1,
            //     name="tom",
            //     addr=ad,
            //     lt=lm,
            //     remark="testProgram"
            // };

            // string json = JsonConvert.SerializeObject(data);

            // Console.WriteLine(json);
        }
    }
}
