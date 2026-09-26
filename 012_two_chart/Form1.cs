using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_two_chart
{
    public partial class using_chartcontrol : Form
    {
        public using_chartcontrol()
        {
            InitializeComponent();
        }

        private void using_chartcontrol_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");
            chart1.Series.Add("Series2");

            chart1.Series[0].LegendText = "영어";
            chart1.Series[1].LegendText = "수학";

            Random r = new Random();
            for(int i = 1; i <= 10; i++)
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101));// X는 i, Y는 r.Next(101), AddXY = X+Y값
                chart1.Series[1].Points.AddXY(i, r.Next(101));
            }

            
        }

        private void btn_twochart_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.Add("ChartArea2");// ChartArea 하나더 추가, 그러나 데이터는 안들어감
            chart1.Series[1].ChartArea = "ChartArea2";
            btn_twochart.Enabled = false;//오류를 막기위해 비활성화
            btn_onechart.Enabled = true;// 그후 합쳐그리기 버튼 활성화

        }

        private void btn_onechart_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.RemoveAt(1);// ChartArea2 제거
            chart1.Series[1].ChartArea = "ChartArea1";
            btn_twochart.Enabled = true;//나눠그리기 버튼 누르고 활성화
            btn_onechart.Enabled = false;// 그후 합쳐그리기 버튼 비활성화

        }
    }
}
