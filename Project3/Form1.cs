namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;   /// 테두리
        private int sizeNun = 30;  /// 눈금
        private int sizeDol = 28;  /// 돌 크기


        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2*margin + 18*sizeNun,    2*margin + 18*sizeNun);   ///가로 세로
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}