namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;   /// �׵θ�
        private int sizeNun = 30;  /// ����
        private int sizeDol = 28;  /// �� ũ��


        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2*margin + 18*sizeNun,    2*margin + 18*sizeNun);   ///���� ����
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}