using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// 날짜 : 2022 / 06/ 21
/// 이름 : 최희원
/// 내용 : DB 프로그래밍
///
/// 
///    MySQL Pakage 설치 : 
///    도구 - NuGet 패키지 관리자 - 솔루션용 NuGet 패키지 관리  / mysql 검색 - ch10 체크 - MySql.Data 설치
///
///       HeidiSQL 으로 DB 건드리기
///    1. C#으로 DB 건드리기 



namespace Ch10
{
    internal class _1_DB_Connection
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
            MySqlConnection conn = new MySqlConnection(strConn);     /// MySqlConnection : ctrl. - usingmysql.data  
                                                                     /// conn : connection 

            
            try                                                      ///접속 에러날 수 있으므로 예외처리
            {   ///DB 접속
                conn.Open();
                Console.WriteLine("접속 성공");
            }
            catch (Exception e) { Console.WriteLine("접속 실패 : " + e.Message); }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료");
            }

        }


    }
}
