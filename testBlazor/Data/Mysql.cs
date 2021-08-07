using System;
using MySql.Data.MySqlClient;   //添加相应的dll文件到bin\Debug\netcoreapp3.1
using System.Threading.Tasks;
using System.Collections.Generic;

namespace testMysql
{
    public class GetMySql
    {
         public Task<SqlData[]> GetSqlDataAsync()
         {
            List<SqlData> lt = new List<SqlData>();

            string con_url="server=10.86.5.205;User=testuser;password=123456;database=company";
            MySqlConnection conn = new MySqlConnection(con_url);
            MySqlDataReader dr=null;
            try{
                string sql="select * from staff";
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                conn.Open();   //open the channel establish the connection; Here there may be excetions. Use the try cathc statement
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                while(dr.Read() == true){
                    string _id  = dr["id"].ToString();
                    string _name = dr["name"].ToString();
                    string _tel = dr["tel"].ToString();
                    string _content = dr["work"].ToString();
                    DateTime dt = (DateTime)dr["Date"];
                    string _date = dt.ToString("yyyy-MM-dd");

                    lt.Add(new SqlData
                    {
                        id = _id,
                        name = _name,
                        tel = _tel,
                        content = _content,
                        date = _date
                    });
                    //Console.WriteLine($"ID: {id} name: {name} tel: {tel} content: {content} date: {date}");
                    //Console.WriteLine($"ID: {string.Format("{0,-3}",id)} name: {string.Format("{0,-9}",name)} tel: {string.Format("{0,-12}",tel)} content: {string.Format("{0,-13}",content)} date: {date}");
                }
            }catch(MySqlException ex){
                Console.WriteLine(ex.Message);
            }finally{
                dr.Close();
                conn.Close();
            }

            return Task.FromResult(lt.ToArray());
        }
    }
}
