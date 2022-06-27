namespace Project1
{
    public partial class Form1 : Form
    {
        private int var1 = 0;
        private int var2 = 0;

        private List<int> list = new List<int>();         /// 숫자list
        private List<int> operators = new List<int>();    /// 연산자list
        private int result = 0;

        private int operator_ = 0;       /// 1:plus, 2:minus, 3:multi, 4:div



        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //txtResult.Text = "1";

            list.Add(1);      /// 배열에 1  1  1 로 저장
            txtResult.Text = string.Join("", list);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "2";

            list.Add(2);
            txtResult.Text = string.Join("", list);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "3";

            list.Add(3);
            txtResult.Text = string.Join("", list);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "4";

            list.Add(4);
            txtResult.Text = string.Join("", list);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "5";

            list.Add(5);
            txtResult.Text = string.Join("", list);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "6";

            list.Add(6);
            txtResult.Text = string.Join("", list);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "7";

            list.Add(7);
            txtResult.Text = string.Join("", list);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "8";

            list.Add(8);
            txtResult.Text = string.Join("", list);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ///txtResult.Text = "9";
            
            list.Add(9);
            txtResult.Text = string.Join("", list);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            var1 = 0;
            var2 = 0;
            operator_ = 0;

            list.Clear();   ///

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            var2 = int.Parse(currentNum);
            list.Clear();   ///

            switch (operator_)
            {
                case 1:
                    result = var1 + var2;
                    break;
                case 2:
                    result = var1 - var2;
                    break;
                case 3:
                    result = var1 * var2;
                    break;
                case 4:
                    result = var1 / var2;
                    break;
            }
            txtResult.Text = result.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // operator_ = 1;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);

            list.Clear();   ///list에 1 1 1  담긴 것을  초기화

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operator_ = 2;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);

            list.Clear();   ///
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operator_ = 3;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);

            list.Clear();   ///
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operator_ = 4;
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);

            list.Clear();   ///
        }

        private void design_Load(object sender, EventArgs e)
        {

        }
    }
}