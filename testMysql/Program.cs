using System;
using MySql.Data.MySqlClient;   //添加相应的dll文件到bin\Debug\netcoreapp3.1
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace testMysql
{
    class Program
    {
        static void Main(string[] args)
        {
            //string con_url="server=10.86.5.205;User=root;password=123456;database=school";
            string con_url = "server=10.86.5.205;port=13306;User=root;password=123456;database=school";
            MySqlConnection conn = new MySqlConnection(con_url);
            MySqlDataReader dr=null;
            try{
                string sql="select * from stu";
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                conn.Open();   //open the channel establish the connection; Here there may be excetions. Use the try cathc statement
                cmd.ExecuteNonQuery();

                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%");
                dr = cmd.ExecuteReader();

                Console.WriteLine("----------------------------------------------------------------------------------");
                while(dr.Read() == true){

                    string data  = dr["data"].ToString();
                    if(!string.IsNullOrEmpty(data))
                    {
                        Console.WriteLine(data);
                        
                        // var dy = JsonConvert.DeserializeObject<dynamic>(data);
                        // Console.WriteLine(dy.shenzheng);
                    }

                    // string name = dr["Name"].ToString();
                    // string tel = dr["Tel"].ToString();
                    // string content = dr["Content"].ToString();
                    // DateTime dt = (DateTime)dr["Date"];
                    // string date = dt.ToString("yyyy-MM-dd");
                    // //Console.WriteLine($"ID: {id} name: {name} tel: {tel} content: {content} date: {date}");
                    // Console.WriteLine($"ID: {string.Format("{0,-3}",id)} name: {string.Format("{0,-9}",name)} tel: {string.Format("{0,-12}",tel)} content: {string.Format("{0,-13}",content)} date: {date}");
                }
                Console.WriteLine("----------------------------------------------------------------------------------");
            }catch(MySqlException ex){
                Console.WriteLine(ex.Message);
            }finally{
                dr.Close();
                conn.Close();
            }
        }
    }
}
