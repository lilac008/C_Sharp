namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];  /// 벽돌 넉넉하게 100개 잡음
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

        double slope; /// 기울기   (vDir = 1일 경우,   slope = 1 : +/우,    slope = -1 : -/좌) 
        double vDir;  /// direction, 공 방향 여부

        Random rand = new Random();




        public Form1() ///생성자?
        {
            InitializeComponent();

            ///Form1 크기
            this.ClientSize = new Size(formW, formH);   /// 창 크기  new Size(숫자, 숫자)
            this.Text = "BlockBreak v1.0";              /// title

            /// 그래픽 객체 생성 
            g = this.CreateGraphics();


            // 블록 초기화, x,y,가로,세로
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

            //라켓 초기화
            /// racket.X = formW / 2 - racketW / 2;
            /// racket.Y = racketY;
            /// racket.Width = racketW;
            /// racket.Height = racketH;
            InitRacket();

            //공 초기화
            /// ball = new Rectangle(); ///위에 선언만해서 객체생성
            /// ball.X = formW / 2 - ballW / 2;
            /// ball.Y = blockY + nBlocks / 10 * blockH;
            /// ball.Width = ballW;
            /// ball.Height = ballH;
            InitBall();

            //기울기값 초기화 (랜덤한 방향으로 떨어짐)
            /// slope = rand.Next(1, 20) / 10.0; ///1~19를 10으로 나누면 0~9사이의 실수
            /// if (rand.Next(2)%2 == 1) 
            /// {
            ///     slope = -slope;
            /// }
            /// vDir = 1; 

        }

        /// 5 초기화 
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
            ball = new Rectangle();           ///위에 선언만해서 객체생성
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            /// 기울기값 초기화
            slope = rand.Next(1, 20) / 10.0;  ///1~19를 10으로 나누면 0~9사이의 실수
            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
            vDir = 1;
        }





        protected override void OnPaint(PaintEventArgs e)   /// override OnPaint tab두번
        {
            //벽돌 그리기 
            /// g.FillRectangle(blockColor, blocks[0]);
            /// g.FillRectangle(blockColor, blocks[1]);  
            /// g.FillRectangle(blockColor, blocks[2]);  
            /// g.FillRectangle(blockColor, blocks[3]);  
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])                          ///4 - if(true) 추가
                { g.FillRectangle(blockColor, blocks[i]); }   ///for 반복 - 벽돌 여러개
            }

            // 라켓 그리기
            g.FillRectangle(racketColor, racket);

            // 공 그리기
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myTimer_Tick(object sender, EventArgs e)  ///myTimer - 동작 - true
        {
            //공 떨어뜨리기
            /// Console.WriteLine("::tick::");
            
            /// ball.Y += 10;
            /// Invalidate();

            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            int x = (int)dx;
            int y = (int)(vDir * slope * dx);    /// slope기울기 수직하강(0)을 기준으로 좌(-) 우(+)  
            Console.WriteLine("x:{0},y:{1}", x, y);

            ball.X += x;
            ball.Y += y;


            // ball이 좌우벽에 충돌했는지 확인
            if (ball.X < 0 || ball.X > formW - ballW)       ///ballx좌표가 form좌표 300이하일때 방향을 바꾼다. -는 +로, +는 -로
            {
                slope = -slope;                             ///반사
            }
            // ball이 라켓에 맞았는지 확인
            if (ball.Y < 0 || racket.IntersectsWith(ball))   ///racket.IntersectsWith() 라켓에 볼이 Intersect했으면(true)
            {
                vDir = -vDir;                                ///반사
            }
            // ball이 벽돌을 맞았는지 확인
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))         ///볼이 블럭과 충돌했으면
                {
                    vDir = -vDir;
                    blockVisible[i] = false;                ///4
                }
            }
            // ball을 라켓으로 놓쳤을 때
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop();                            ///Tick을 끝냄

                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();                        ///5
                    InitRacket();                        ///5
                    InitBall();                          ///5

                    myTimer.Start();                     ///6 재시작
                }
                else { this.Close(); }
                ///return;                              ///여기서 return;하면 탈출해서 Invalidate(); 실행안함
            }
            //모든 벽돌을 다 깼을때 (숙제)


            Invalidate(); ///

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) ///속성 - 이벤트 - 키 - KeyDown
        {
            if (e.KeyCode == Keys.Left)
            { racket.X -= 10; }
            else if (e.KeyCode == Keys.Right)
            { racket.X += 10; }

            Invalidate(); /// 화면전환(frame)했던 걸 다시그려야함. 이 선언을 안하면 화면이 멈춰있음.
        }
    }
}