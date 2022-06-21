using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _3_Select
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
            MySqlConnection conn = new MySqlConnection(strConn);   ///MySqlConnection : ctrl. - using mysql.data  
                                                                   ///conn = connection접속 에러날수 있으므로 예외처리

            try
            { ///DB 접속
                conn.Open();
                Console.WriteLine("성공");

                ///SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";
                MySqlDataReader reader = cmd.ExecuteReader();   ///select : insert등과 다르게 db에서 데이터를 내려받는다.

                ///결과 출력
                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3}", reader[0], reader[1], reader[2], reader[3]);
                }
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
