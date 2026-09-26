using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//프로그램 끝내기, 실행하고 끝내기 누르면 창이 닫힘
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아직 만들지 않았습니다", "경고");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;//시간이 흐르고
            timer1.Interval = 10;//1초마다는 1000, 10은 0.1초에 한번씩
            //Timer_Tick이라는 이벤트를 발생시킨
            timer1.Tick += Timer_Tick;//+=입력하고 탭을 누르면

            lblDate.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
            lblDate.ForeColor = Color.DarkOrange;
            lblTime.Font = new Font("맑은 고딕", 32, FontStyle.Bold);
            lblTime.ForeColor = Color.DarkBlue;
        }

        private void Timer_Tick(object sender, EventArgs e)//이게 같이 만들어짐
        {
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");
            lblTime.Text = DateTime.Now.ToString("tt h:mm:ss.fff");
            lblDate.Location = new Point(ClientSize.Width / 2 - lblDate.Width / 2, ClientSize.Height / 2 - lblDate.Height / 2 - 30);//lbl.Date위치는 가운대에서 -30
            lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2, ClientSize.Height / 2 - lblTime.Height / 2 + 30);//lbl.Time위치는 가운대로 재배치 +30
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
                timer1.Enabled = true;
        }
    }
}
