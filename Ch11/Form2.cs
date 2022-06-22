using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tem3
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            ///comboBox 데이터 공급
            ///List<string> positions = new List<string>() { "사원","대리","과장","차장","부장"};
            ///cbPosition.DataSource = positions;
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)        ///form2가 로드될 때 실행
        {

            //2-1 comboBox 데이터 공급
            List<string> positions = new List<string>() { "사원","대리","과장","차장","부장"};
            cbPosition.DataSource = positions;

            string[] hobbies = {"등산하기","운동하기","영화하기","독서하기","게임하기" };
            cbHobby.DataSource = hobbies;



            //2-2 ListBox 데이터 공급
            string[] country = { "대한민국", "미국", "일본", "중국", "대만", "호주", "영국", "프랑스", "독일", "스페인"};
            lstCountry.DataSource = country;



            //2-3 DataGridView 공급
            List<Member> mbs = new List<Member>();
            mbs.Add(new Member("a101", "김유신", "010-1234-1001", 14));
            mbs.Add(new Member("a102", "김춘추", "010-1234-1002", 24));
            mbs.Add(new Member("a103", "장보고", "010-1234-1003", 34));
            mbs.Add(new Member("a104", "강감찬", "010-1234-1004", 44));
            mbs.Add(new Member("a105", "이순신", "010-1234-1005", 54));
            dgvMember.DataSource = mbs;

        }

        /// 2-1 comboBox 공급
        private void btnPosition_Click(object sender, EventArgs e)
        { lbResultPosition.Text = "결과 : " + cbPosition.Text; }
        
        private void btnHobby_Click(object sender, EventArgs e)
        { lbResultHobby.Text = "결과 : " + cbHobby.Text; }



        /// 2-2 ListBox 공급
        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        { lbResultCountry.Text = "결과 : " + lstCountry.Text; }




        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
