using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        Graphics graphics;
        Rectangle myRect = new Rectangle();

        Brush blueBrush = new SolidBrush(Color.Blue);
        Pen blackPen = new Pen(Color.Black);

        protected override void OnPaint(PaintEventArgs e)  /// override OnPaint 탭두번
        {
            Console.WriteLine("OnPaint!");  /// 다시 그리도록 갱신
            graphics.DrawRectangle(blackPen, myRect);
            graphics.FillRectangle(blueBrush, myRect);
        }

        public Form3()   /// 생성자
        {
            InitializeComponent();

            graphics = this.CreateGraphics();
            myRect.X = 360;
            myRect.Y = 10;
            myRect.Width = 10;
            myRect.Height = 10;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 10, 100, 100); ///x축, y축, 가로, 세로

            g.DrawRectangle(blackPen, rect);   ///도형그리기
            g.FillRectangle(redBrush, rect);   ///도형 색 채우기
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);

            g.DrawLine(blackPen, new Point(10, 120), new Point(200, 120)); ///선 그리기 - start Point(x,y),end Point(x,y)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush greenBrush = new SolidBrush(Color.Green);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(120, 10, 100, 100); ///x축, y축, 가로, 세로
            g.FillEllipse(greenBrush, rect);    ///원 채우기
            g.DrawEllipse(blackPen, rect);      ///선 채우기
        }

        private void myTimer_Tick(object sender, EventArgs e)  ///mytimer - 이벤트(번개) - Tick 
        {
            Console.WriteLine("::MyTimer::");

            myRect.Y += 10;   /// 도형 떨어뜨리기,  -=하면 위로 올라간다.

            Invalidate();     /// 다시 그리도록 갱신
        }
    }
}
