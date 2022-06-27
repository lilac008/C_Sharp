using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// DB ���� ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "tester";
            string password = "1q2w3e";
            string database = "testdb";

            /// DB ���� ����
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);   ///using Mysql.Data.MySqlClient;


            ///DB ���� ����Ʈ ����
            List<User> users = new List<User>();

            try
            {
                conn.Open();                                    /// DB����


                MySqlCommand cmd = conn.CreateCommand();        /// SQL ����
                cmd.CommandText = "SELECT * FROM `user2`";

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())                           /// ��� List ����(user2�� data 5��(�����԰��)�� �о����)
                {
                    User user =  new User();
                    user.Uid  =  reader[0].ToString();
                    user.Name =  reader[1].ToString();
                    user.Hp   =  reader[2].ToString();
                    user.Age  =  Convert.ToInt32(reader[3]);

                    users.Add(user);
                }
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            finally
            {
                conn.Close();                                 /// DB ����
            }


            /// DataGridView ������ ����
            dataGridView1.DataSource = users;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid  = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp   = txtHp.Text.ToString();
            string age  = nAge.Text.ToString();

            /// DB ���� ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "tester";
            string password = "1q2w3e";
            string database = "testdb";

            /// DB ����
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `user2` VALUES ('{uid}', '{name}', '{hp}', {age})";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ecp)
            {
                Console.WriteLine(ecp.Message);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("�����Ͱ� ����Ǿ����ϴ�.", "Insert �Ϸ�");
            Reset();             ///1-2 reset() method

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();             ///1-2 reset() method
        }

        /// �߰� : 1-1 reset() method ����
        public void Reset()
        {
            txtUid.Text  = "";
            txtName.Text = "";
            txtHp.Text   = "";
            nAge.Text    = "0";
        }






    }
}