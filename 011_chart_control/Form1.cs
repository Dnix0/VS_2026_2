using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_chart_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");

            chart1.Series[0].Points.Add(55);// 첫번째 데이터에 55점 추가
            chart1.Series[0].Points.Add(68);
            chart1.Series[0].Points.Add(79);
            chart1.Series[0].Points.Add(48);
            chart1.Series[0].Points.Add(80);
            //for (int i = 0; i < 10; i++)
            //{
            //    chart1.Series[0].Points.Add((i + 1) * 10);
            //}
            chart1.Series[0].LegendText = "비주얼\n프로그래밍";// 데이터의 이름을 입력

            chart1.Series.Add("Design");// 새로운 데이터 추가
            chart1.Series[1].Points.Add(70);
            chart1.Series[1].Points.Add(80);
            chart1.Series[1].Points.Add(90);
            chart1.Series[1].Points.Add(95);
            chart1.Series[1].Points.Add(85);


            chart1.Series[1].LegendText = "설계";
        }
    }
}
