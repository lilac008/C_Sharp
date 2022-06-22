namespace tem3
{
    public partial class Form1 : Form    ///ctrl �������¿��� Ŭ��
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// 1. Button Control ����
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�޽����ڽ�","�޽����ڽ�1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �ִ� �޽����ڽ�", "�޽����ڽ�2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ΰ��� ��ư�� ���� �޽����ڽ�", "�޽����ڽ�3", MessageBoxButtons.YesNo);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ��ư�� ���� �޽����ڽ�", "�޽����ڽ�4");
        }


        /// 2. TextBox Control ����
        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;   
            lbUid.Text = "��� : " + uid;          /// ���̵� �Է� = ��� �Է�
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "��� : " + txtName.Text;
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            lbHP.Text = "��� : " + txtHP.Text;
        }


        /// 3. Check Box Control ����
        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] cbFArray = {chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };    /// chechbox class 
            List<string> fruits = new List<string>();
            foreach (CheckBox cbFA in cbFArray)               ///checkbox ��ü�� 5���̹Ƿ� 5�� �ݺ�
            {
                if (cbFA.Checked) 
                {
                    fruits.Add(cbFA.Text); 
                }
            }
            lbResultFruit.Text = "������ ���� : " + String.Join(", ", fruits);
        }


        /// 4. RadioButton Box Control ���� 
        private void btnGender_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbResultGender.Text = "��� : ����";
            }
            else { lbResultGender.Text = "��� : ����"; }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked) { lbResultYear.Text = "��� : 1�г�"; }
            else if (rdYear2.Checked) { lbResultYear.Text = "��� : 2�г�"; }
            else if (rdYear3.Checked) { lbResultYear.Text = "��� : 3�г�"; }
            else if (rdYear4.Checked) { lbResultYear.Text = "��� : 4�г�"; }
        }


        /// 5. Form2 ����
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();    ///form2.Show();
        }

    }
}