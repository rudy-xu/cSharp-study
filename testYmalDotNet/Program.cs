using System;
//using YamlDotNet.Samples.Helpers;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace testYmalDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string,string> dic = new Dictionary<string, string>();

            var yaml = new YamlStream();
            using (var reader = new StreamReader(@"C:\config\config.yml")) {
                // Load the stream
                
                yaml.Load(reader);
                Console.WriteLine(yaml);
                // the rest
            }
                        // Examine the stream

            var mapping =
                (YamlMappingNode)yaml.Documents[0].RootNode;

            Console.WriteLine(mapping);

            foreach (var entry in mapping.Children)
            {
                Console.WriteLine(((YamlScalarNode)entry.Key).Value);
                Console.WriteLine(((YamlScalarNode)entry.Value).Value);
                string str1 = ((YamlScalarNode)entry.Key).Value.ToString();
                string str2 = ((YamlScalarNode)entry.Value).Value.ToString();
                dic.Add(str1,str2);
            }

            Console.WriteLine("port:{0}",dic["password"]);

            // // List all the items
            // var items = (YamlSequenceNode)mapping.Children[new YamlScalarNode("items")];
            // foreach (YamlMappingNode item in items)
            // {
            //     Console.WriteLine(
            //         "{0}\t{1}",
            //         item.Children[new YamlScalarNode("part_no")],
            //         item.Children[new YamlScalarNode("descrip")]
            //     );
            // }

            // string str =@"scalar: a scalar,sequence:one";

            // var input = new StringReader(str);
            // var deserializer = new DeserializerBuilder().Build();
            // var yamlObject = deserializer.Deserialize(input);

            // var serializer = new SerializerBuilder().JsonCompatible().Build();
            // var json = serializer.Serialize(yamlObject);
            // Console.WriteLine(json);
        }
    }
}
