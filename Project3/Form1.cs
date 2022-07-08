namespace Project3
{
    public partial class Form1 : Form
    {
        ///1
        private int margin = 40;     /// 테두리
        private int sizeNun = 30;    /// 눈금
        private int sizeDol = 25;    /// 돌 크기

        ///2
        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        ///3
        bool isBlack = true;   /// 현재 검은돌이면


        ///4 같은 돌 겹침 방지 (2D Array?)?????????
        enum STONE { none, black, white };
        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();

            ///1 바둑판 색, 크기
            this.Text = "오목 v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);   ///가로, 세로


            ///2 그래픽 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);


        }



        ///직접입력
        protected override void OnPaint(PaintEventArgs e) 
        {
            ///2 바둑판 눈금 그리기
            ///g.DrawLine(pen, new Point(margin + 10*1, 10), new Point(margin + 10*1, 500));  // 세로 : 시작지점, 끝지점
            ///g.DrawLine(pen, new Point(margin + 10*2, 10), new Point(margin + 10*2, 500));

            ///g.DrawLine(pen, new Point(margin + sizeNun * 1, margin), new Point(margin + sizeNun * 1, margin + 18 * sizeNun));
            ///g.DrawLine(pen, new Point(margin + sizeNun * 2, margin), new Point(margin + sizeNun * 2, margin + 18 * sizeNun));

            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i));
            }
        }


        ///속성 - 이벤트(번개모양) - MouseDown
        private void Form1_MouseDown(object sender, MouseEventArgs e) ///좌표값을 e가 들고있다
        {

            /// 좌표값 
            ///Console.WriteLine("::Mouse Down::");
            ///Console.WriteLine("x:{0},y:{1}", e.X, e.Y);


            /// 가장 가까운 좌표값으로 고정
            int x = (e.X - margin + sizeNun / 2) / sizeNun;         
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            Console.WriteLine(":Mouse Down:");
            Console.WriteLine("x:{0},y:{1}", x, y);


            /// 흑돌, 백돌 번갈아 나오게
            ///Rectangle dol = new Rectangle(x, y, sizeDol, sizeDol);
            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);
            ///if (isBlack)
            ///{
            ///    g.FillEllipse(bBrush, dol);
            ///    isBlack = false;
            ///}
            ///else
            ///{
            ///    g.FillEllipse(wBrush, dol);
            ///    isBlack = true;
            ///}

            ///흑돌백돌 번갈아나오게 + 돌 겹침 방지
            if (dataSet[x, y] != STONE.none)   ///해당눈금에 돌이 놓여있으면
            {
                MessageBox.Show("이미 돌이 놓여있습니다.");
                return;     ///method 종료 - void기에 값을 반환하면 안됨. 
            }

            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                dataSet[x, y] = STONE.black;

                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;

                isBlack = true;
            }

            CheckOmok(x, y);  /// 오목 여부 판정
        }

        ///직접 추가
        public void CheckOmok(int x, int y)
        {
            int count = 1; /// 돌을 놓는 순간 count 1

            /// 우
            for (int i = x + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            /// 좌
            for (int i = x - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);    ///오류점검
            ///count = 1;                 ///초기화

            /// 상
            for (int i = y - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///하
            for (int i = y + 1; i >= 0; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);
            ///count = 1;

            /// 대각선 11시
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            /// 대각선 4시
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);
            ///count = 1;

            /// 대각선 1시
            for (int i = x + 1, j = y - 1; i <= 18 && j >= 0; i++, j--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            /// 대각선 7시
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18; i--, j++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);
        }

        ///직접추가 바둑판에 놓인 바둑알 초기화???
        public void NewGame()
        {
            /// 화면갱신 -> OnPaint 호출
            this.Invalidate();


            /// 데이터셋 초기화
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    dataSet[x, y] = STONE.none;

            /// 검은돌 시작
            isBlack = true;
        }

        /// 직접 추가 - 오류 판별 확인법
        public void CheckCountAlert(int count)
        {
            if (count >= 5)
            {
                DialogResult result = MessageBox.Show("오목입니다! 새로운 게임을 시작할까요?",
                                                      "확인",
                                                      MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {




              
        }
    }
}