namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];  /// ���� �˳��ϰ� 100�� ����
        bool[] blockVisible = new bool[100];       /// 4

        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.CornflowerBlue);
        Brush ballColor = new SolidBrush(Color.Gold);
        Brush blockColor = new SolidBrush(Color.Orange);
        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;

        int nBlocks = 20;

        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        double slope; /// ����   (vDir = 1�� ���,   slope = 1 : +/��,    slope = -1 : -/��) 
        double vDir;  /// direction, �� ���� ����

        Random rand = new Random();




        public Form1() ///������?
        {
            InitializeComponent();

            ///Form1 ũ��
            this.ClientSize = new Size(formW, formH);   /// â ũ��  new Size(����, ����)
            this.Text = "BlockBreak v1.0";              /// title

            /// �׷��� ��ü ���� 
            g = this.CreateGraphics();


            // ��� �ʱ�ȭ, x,y,����,����
            /// blocks[0] = new Rectangle(10,10,20,10);   
            /// blocks[1] = new Rectangle(35,10,20,10);  
            /// blocks[2] = new Rectangle(60,10,20,10);  
            /// blocks[3] = new Rectangle(85,10,20,10);  

            /// for (int i = 0; i < nBlocks; i++)
            /// {
            ///     blocks[i] = new Rectangle(i % 10 * blockW,
            ///                               blockY + blockH * (i / 10),
            ///                               blockW - 1,
            ///                               blockH - 1);
            /// 
            ///     ///4
            ///     blockVisible[i] = true;
            /// }
            InitBlocks();

            //���� �ʱ�ȭ
            /// racket.X = formW / 2 - racketW / 2;
            /// racket.Y = racketY;
            /// racket.Width = racketW;
            /// racket.Height = racketH;
            InitRacket();

            //�� �ʱ�ȭ
            /// ball = new Rectangle(); ///���� �����ؼ� ��ü����
            /// ball.X = formW / 2 - ballW / 2;
            /// ball.Y = blockY + nBlocks / 10 * blockH;
            /// ball.Width = ballW;
            /// ball.Height = ballH;
            InitBall();

            //���Ⱚ �ʱ�ȭ (������ �������� ������)
            /// slope = rand.Next(1, 20) / 10.0; ///1~19�� 10���� ������ 0~9������ �Ǽ�
            /// if (rand.Next(2)%2 == 1) 
            /// {
            ///     slope = -slope;
            /// }
            /// vDir = 1; 

        }

        /// 5 �ʱ�ȭ 
        public void InitBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);

                blockVisible[i] = true;         ///4
            }
        }
        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void InitBall()
        {
            ball = new Rectangle();           ///���� �����ؼ� ��ü����
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            /// ���Ⱚ �ʱ�ȭ
            slope = rand.Next(1, 20) / 10.0;  ///1~19�� 10���� ������ 0~9������ �Ǽ�
            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
            vDir = 1;
        }





        protected override void OnPaint(PaintEventArgs e)   /// override OnPaint tab�ι�
        {
            //���� �׸��� 
            /// g.FillRectangle(blockColor, blocks[0]);
            /// g.FillRectangle(blockColor, blocks[1]);  
            /// g.FillRectangle(blockColor, blocks[2]);  
            /// g.FillRectangle(blockColor, blocks[3]);  
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])                          ///4 - if(true) �߰�
                { g.FillRectangle(blockColor, blocks[i]); }   ///for �ݺ� - ���� ������
            }

            // ���� �׸���
            g.FillRectangle(racketColor, racket);

            // �� �׸���
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myTimer_Tick(object sender, EventArgs e)  ///myTimer - ���� - true
        {
            //�� ����߸���
            /// Console.WriteLine("::tick::");
            
            /// ball.Y += 10;
            /// Invalidate();

            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            int x = (int)dx;
            int y = (int)(vDir * slope * dx);    /// slope���� �����ϰ�(0)�� �������� ��(-) ��(+)  
            Console.WriteLine("x:{0},y:{1}", x, y);

            ball.X += x;
            ball.Y += y;


            // ball�� �¿캮�� �浹�ߴ��� Ȯ��
            if (ball.X < 0 || ball.X > formW - ballW)       ///ballx��ǥ�� form��ǥ 300�����϶� ������ �ٲ۴�. -�� +��, +�� -��
            {
                slope = -slope;                             ///�ݻ�
            }
            // ball�� ���Ͽ� �¾Ҵ��� Ȯ��
            if (ball.Y < 0 || racket.IntersectsWith(ball))   ///racket.IntersectsWith() ���Ͽ� ���� Intersect������(true)
            {
                vDir = -vDir;                                ///�ݻ�
            }
            // ball�� ������ �¾Ҵ��� Ȯ��
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))         ///���� ���� �浹������
                {
                    vDir = -vDir;
                    blockVisible[i] = false;                ///4
                }
            }
            // ball�� �������� ������ ��
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop();                            ///Tick�� ����

                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "Ȯ��", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();                        ///5
                    InitRacket();                        ///5
                    InitBall();                          ///5

                    myTimer.Start();                     ///6 �����
                }
                else { this.Close(); }
                ///return;                              ///���⼭ return;�ϸ� Ż���ؼ� Invalidate(); �������
            }
            //��� ������ �� ������ (����)


            Invalidate(); ///

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) ///�Ӽ� - �̺�Ʈ - Ű - KeyDown
        {
            if (e.KeyCode == Keys.Left)
            { racket.X -= 10; }
            else if (e.KeyCode == Keys.Right)
            { racket.X += 10; }

            Invalidate(); /// ȭ����ȯ(frame)�ߴ� �� �ٽñ׷�����. �� ������ ���ϸ� ȭ���� ��������.
        }
    }
}