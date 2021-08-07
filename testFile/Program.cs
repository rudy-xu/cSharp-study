using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace testFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Dictionary<string, ArrayList> dic = new Dictionary<string, ArrayList>();
            //List<ArrayList> list = new List<ArrayList>();

            char[] charsToTrim = {'{','"','}'};
            string path=@"C:\sioux_rl\Sioux\work\C#_test\testFile\tempFile.log";

            if(!File.Exists(path))
            {
                Console.WriteLine("Hello tom! The file is not exist!");
            }
            else
            {
                StreamReader sr = new StreamReader(path);
                string line;
                while((line = sr.ReadLine()) != null){
                    JObject jo = (JObject)JsonConvert.DeserializeObject(line);
                    Console.WriteLine(jo["Life_time(s)"]);

                    //string[] str = line.Split(",");
                    //ArrayList element = new ArrayList();
                    
                    // foreach (string item in str)
                    // {
                    //     ArrayList element = new ArrayList();
                    //     string[] temp = item.Split(":");

                    //     string key;
                    //     string value;
                    //     if(temp.Length<3){
                    //         key = temp[0].Trim(charsToTrim);
                    //         value = temp[1].Trim(charsToTrim);
                    //     }else{
                    //         key = temp[1].Trim(charsToTrim);
                    //         value = temp[2].Trim(charsToTrim);
                    //     }

                    //     element.Add(value);
                    //     if(!dic.ContainsKey(key)){
                    //         dic.Add(key,element);
                    //     }else{
                    //         ArrayList res = new ArrayList();
                    //         dic.TryGetValue(key, out res);
                    //         res.Add(value);
                    //     }
                    //     //ht.Add(key,value);
                    // }

////////////////////////////--List<ArrayList>--/////////////////////////////////
                    // foreach (string item in str)
                    // {
                    //     string[] temp = item.Split(":");

                    //     string res;
                    //     if(temp.Length<3){
                    //         res = temp[1].Trim(charsToTrim);
                    //     }else{
                    //         res = temp[2].Trim(charsToTrim);
                    //     }
                    //     element.Add(res);
                    // }
                    // list.Add(element);
                }

                sr.Close();
            }

            // foreach (KeyValuePair<string, ArrayList> item in dic)
            // {
            //     Console.Write("key={0} , Value= ",item.Key);
            //     foreach (var tmp in item.Value)
            //     {
            //         Console.Write(tmp+" ");
            //     }
            //     Console.WriteLine();
            // }

/////////////////////---show List<ArrayList>----/////////////////////
            // foreach (var item in list)
            // {
            //     foreach (var item2 in item)
            //     {
            //         Console.Write(item2+" ");   
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}
