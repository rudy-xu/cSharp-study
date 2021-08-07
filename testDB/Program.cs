using System;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

namespace testDB
{
    class Program
    {
        static void Main(string[] args)
        {
           string conUrl="server=localhost;User=root;password=Aa123456;database=school";
            MySqlConnection conn = new MySqlConnection(conUrl);
            MySqlDataReader dr=null;
            string Tel = "\'192070010"+"\'";
            string sqlSearch = $"select * from stu where Tel={Tel}";

            try{
                MySqlCommand cmd = new MySqlCommand(sqlSearch,conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();
                while(dr.Read() == true)
                {
                    Console.WriteLine(dr["data"]);
                    Console.WriteLine("----------------------------------------");
                    var dy = JsonConvert.DeserializeObject<dynamic>(dr["data"].ToString());
                    Console.WriteLine(dy.shanghai[0].zj1);
                }
            }catch(MySqlException me){
                Console.WriteLine(me.Message);
            }finally{
                dr.Close();
                conn.Close();
            }

        }
    }
}
