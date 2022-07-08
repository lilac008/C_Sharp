namespace Project3
{
    public partial class Form1 : Form
    {
        ///1
        private int margin = 40;     /// �׵θ�
        private int sizeNun = 30;    /// ����
        private int sizeDol = 25;    /// �� ũ��

        ///2
        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        ///3
        bool isBlack = true;   /// ���� �������̸�


        ///4 ���� �� ��ħ ���� (2D Array?)?????????
        enum STONE { none, black, white };
        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();

            ///1 �ٵ��� ��, ũ��
            this.Text = "���� v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);   ///����, ����


            ///2 �׷��� ��ü �ʱ�ȭ
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);


        }



        ///�����Է�
        protected override void OnPaint(PaintEventArgs e) 
        {
            ///2 �ٵ��� ���� �׸���
            ///g.DrawLine(pen, new Point(margin + 10*1, 10), new Point(margin + 10*1, 500));  // ���� : ��������, ������
            ///g.DrawLine(pen, new Point(margin + 10*2, 10), new Point(margin + 10*2, 500));

            ///g.DrawLine(pen, new Point(margin + sizeNun * 1, margin), new Point(margin + sizeNun * 1, margin + 18 * sizeNun));
            ///g.DrawLine(pen, new Point(margin + sizeNun * 2, margin), new Point(margin + sizeNun * 2, margin + 18 * sizeNun));

            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i));
            }
        }


        ///�Ӽ� - �̺�Ʈ(�������) - MouseDown
        private void Form1_MouseDown(object sender, MouseEventArgs e) ///��ǥ���� e�� ����ִ�
        {

            /// ��ǥ�� 
            ///Console.WriteLine("::Mouse Down::");
            ///Console.WriteLine("x:{0},y:{1}", e.X, e.Y);


            /// ���� ����� ��ǥ������ ����
            int x = (e.X - margin + sizeNun / 2) / sizeNun;         
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            Console.WriteLine(":Mouse Down:");
            Console.WriteLine("x:{0},y:{1}", x, y);


            /// �浹, �鵹 ������ ������
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

            ///�浹�鵹 �����Ƴ����� + �� ��ħ ����
            if (dataSet[x, y] != STONE.none)   ///�ش紫�ݿ� ���� ����������
            {
                MessageBox.Show("�̹� ���� �����ֽ��ϴ�.");
                return;     ///method ���� - void�⿡ ���� ��ȯ�ϸ� �ȵ�. 
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

            CheckOmok(x, y);  /// ���� ���� ����
        }

        ///���� �߰�
        public void CheckOmok(int x, int y)
        {
            int count = 1; /// ���� ���� ���� count 1

            /// ��
            for (int i = x + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            /// ��
            for (int i = x - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);    ///��������
            ///count = 1;                 ///�ʱ�ȭ

            /// ��
            for (int i = y - 1; i >= 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///��
            for (int i = y + 1; i >= 0; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);
            ///count = 1;

            /// �밢�� 11��
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            /// �밢�� 4��
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);
            ///count = 1;

            /// �밢�� 1��
            for (int i = x + 1, j = y - 1; i <= 18 && j >= 0; i++, j--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            /// �밢�� 7��
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18; i--, j++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            ///CheckCountAlert(count);
        }

        ///�����߰� �ٵ��ǿ� ���� �ٵϾ� �ʱ�ȭ???
        public void NewGame()
        {
            /// ȭ�鰻�� -> OnPaint ȣ��
            this.Invalidate();


            /// �����ͼ� �ʱ�ȭ
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    dataSet[x, y] = STONE.none;

            /// ������ ����
            isBlack = true;
        }

        /// ���� �߰� - ���� �Ǻ� Ȯ�ι�
        public void CheckCountAlert(int count)
        {
            if (count >= 5)
            {
                DialogResult result = MessageBox.Show("�����Դϴ�! ���ο� ������ �����ұ��?",
                                                      "Ȯ��",
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