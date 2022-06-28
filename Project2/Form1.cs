using MySql.Data.MySqlClient;




namespace Project2  /// Project2 : 우클릭 - 속성 - 콘솔 애플리케이션
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// DB 접속 정보 (DBAccess로 이동)
            /// DB 접속 연결 (DBAccess로 이동)

            /// DB 공급 리스트 생성  (try(while), catch, finally는 DBAccess로)
            List<User> users = new List<User>();


            /// DataGridView 데이터 공급
            dataGridView1.DataSource = users;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid  = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp   = txtHp.Text.ToString();
            decimal age = nAge.Value;             


            /// DB 접속 정보 (DBAccess로 이동)
            /// DB 연결 + try,catch,finally  (DBAccess로 이동)

            DBAccess.Instance.InsertUser(uid, name, hp, age);      ///

            Reset();                       ///1-2 reset
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();                      ///1-2 reset
        }

        public void Reset()  /// 새로 추가 : 1-1 Reset() method 정의
        {
            txtUid.Text  = "";
            txtName.Text = "";
            txtHp.Text   = "";
            nAge.Text    = "0";
        }


        ///dataGridView지정 - 속성 - 번개모양 - CellClick
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            string uid  = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string hp   = row.Cells[2].Value.ToString();
            int age     = (int)row.Cells[3].Value;

            txtUid.Text = uid;
            txtName.Text = name;
            txtHp.Text = hp;
            nAge.Value = age;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid  = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp   = txtHp.Text.ToString();
            decimal age = nAge.Value;

            DBAccess.Instance.UpdateUser(uid, name, hp, age);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<User> users = DBAccess.Instance.SelectUsers();
            dataGridView1.DataSource = users;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            DBAccess.Instance.DeleteUser(uid);
        }


    }
}