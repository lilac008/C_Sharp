using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        ///1 DB 접속 정보
        private const string SERVER = "127.0.0.1";   /// const : 상수 (값을 변경할 수 없음)
        private const string PORT = "3306";
        private const string USERNAME = "tester";
        private const string PASSWORD = "1q2w3e";
        private const string DATABASE = "testdb";
        private const string TABLE = "user2";


        /// 싱글톤
        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        public MySqlConnection Connect()   ///return : MySqlConnection    
        {
            ///2 DB 접속 연결
            string strConn = $"server={SERVER};port={PORT};username={USERNAME};password={PASSWORD};database={DATABASE};";
            MySqlConnection conn = new MySqlConnection(strConn);       ///using Mysql.Data.MySqlClient;
            return conn;                   ///return
        }



        /// public void InsertUser() { }
        /// public void SelectUser() { }
        /// public List<User> SelectUsers() { }
        /// public void UpdateUser() { }
        /// public void DeleteUser() { }
        /// 
        /// 
        public void InsertUser(string uid, string name, string hp, decimal age)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();                                 /// DB 접속

                MySqlCommand cmd = conn.CreateCommand();     /// SQL 실행
                cmd.CommandText = $"INSERT INTO `{TABLE}` VALUES ('{uid}', '{name}', '{hp}', {age})";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally { conn.Close(); }                        /// DB 종료
            MessageBox.Show("데이터가 저장되었습니다.", "Insert 완료");
        }


        public void SelectUser() { }


        public List<User> SelectUsers()
        {
            List<User> users = new List<User>();             /// DB 공급 리스트 생성

            MySqlConnection conn = Connect();

            try
            {
                conn.Open();                                 /// DB 접속

                MySqlCommand cmd = conn.CreateCommand();     /// SQL 실행
                cmd.CommandText = "SELECT * FROM `user2`";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())                        /// 결과 List 생성(user2의 data 5개(선생님경우)를 읽어오기)
                {
                    User user = new User();
                    user.Uid  = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp   = reader[2].ToString();
                    user.Age  = Convert.ToInt32(reader[3]);

                    users.Add(user);
                }
            }
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally { conn.Close(); }                       /// DB 종료

            return users;
        }


        public void UpdateUser(string uid, string name, string hp, decimal age)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {TABLE} SET `name`='{name}', `hp`='{hp}', `age`={age} WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally { conn.Close(); }
            MessageBox.Show("데이터가 수정되었습니다.", "Update 완료");
        }


        public void DeleteUser(string uid)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM {TABLE} WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except) { Console.WriteLine(except.Message); }
            finally { conn.Close(); }
            MessageBox.Show("데이터가 삭제되었습니다.", "Delete 완료");
        }

    }
}
