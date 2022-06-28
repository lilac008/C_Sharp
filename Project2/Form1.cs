using MySql.Data.MySqlClient;




namespace Project2  /// Project2 : ��Ŭ�� - �Ӽ� - �ܼ� ���ø����̼�
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// DB ���� ���� (DBAccess�� �̵�)
            /// DB ���� ���� (DBAccess�� �̵�)

            /// DB ���� ����Ʈ ����  (try(while), catch, finally�� DBAccess��)
            List<User> users = new List<User>();


            /// DataGridView ������ ����
            dataGridView1.DataSource = users;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid  = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp   = txtHp.Text.ToString();
            decimal age = nAge.Value;             


            /// DB ���� ���� (DBAccess�� �̵�)
            /// DB ���� + try,catch,finally  (DBAccess�� �̵�)

            DBAccess.Instance.InsertUser(uid, name, hp, age);      ///

            Reset();                       ///1-2 reset
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();                      ///1-2 reset
        }

        public void Reset()  /// ���� �߰� : 1-1 Reset() method ����
        {
            txtUid.Text  = "";
            txtName.Text = "";
            txtHp.Text   = "";
            nAge.Text    = "0";
        }


        ///dataGridView���� - �Ӽ� - ������� - CellClick
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