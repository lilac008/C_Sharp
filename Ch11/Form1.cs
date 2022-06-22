namespace tem3
{
    public partial class Form1 : Form    ///ctrl 누른상태에서 클릭
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// 1. Button Control 연습
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지박스","메시지박스1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "메시지박스2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두개의 버튼을 갖는 메시지박스", "메시지박스3", MessageBoxButtons.YesNo);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("세개의 버튼을 갖는 메시지박스", "메시지박스4");
        }


        /// 2. TextBox Control 연습
        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;   
            lbUid.Text = "결과 : " + uid;          /// 아이디 입력 = 결과 입력
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "결과 : " + txtName.Text;
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            lbHP.Text = "결과 : " + txtHP.Text;
        }


        /// 3. Check Box Control 연습
        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] cbFArray = {chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };    /// chechbox class 
            List<string> fruits = new List<string>();
            foreach (CheckBox cbFA in cbFArray)               ///checkbox 객체가 5개이므로 5번 반복
            {
                if (cbFA.Checked) 
                {
                    fruits.Add(cbFA.Text); 
                }
            }
            lbResultFruit.Text = "선택한 과일 : " + String.Join(", ", fruits);
        }


        /// 4. RadioButton Box Control 연습 
        private void btnGender_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbResultGender.Text = "결과 : 남자";
            }
            else { lbResultGender.Text = "결과 : 여자"; }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked) { lbResultYear.Text = "결과 : 1학년"; }
            else if (rdYear2.Checked) { lbResultYear.Text = "결과 : 2학년"; }
            else if (rdYear3.Checked) { lbResultYear.Text = "결과 : 3학년"; }
            else if (rdYear4.Checked) { lbResultYear.Text = "결과 : 4학년"; }
        }


        /// 5. Form2 띄우기
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();    ///form2.Show();
        }

    }
}