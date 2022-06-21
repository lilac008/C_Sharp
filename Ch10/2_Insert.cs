using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _2_Insert
    {
        static void Main1(string[] args)
        {
            /// DB 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "tester";
            string password = "1q2w3e";
            string database = "testdb";


            /// DB Connection 생성
            string strConn = $"server={server}; port={port}; username={username}; password={password}; database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);     
                                                                   

            try
            {   ///DB 접속
                conn.Open();
                Console.WriteLine("성공");

                ///SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INCERT INTO `user1` VALUES ('c101', '김유신', '010-1234-1010',27)";    /// user1에 정보가 추가된다. 여러번 실행하면 반복됨. user2는 primary key설정으로 중복 허용 되지 않는다.
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine("실패 : " + e.Message); }
            finally
            {
                conn.Close();
                Console.WriteLine("종료");
            }
        }






    }
}
