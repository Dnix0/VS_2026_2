using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);//Parse는 문자열을 숫자로 바꿔주는 함수
            double w = double.Parse(txtW.Text);//txtW.Text는 텍스트박스에 입력된 문자열을 가져오는 것

            h /= 100;

            double bmi = w / (h * h);
            label3.Text = bmi.ToString();//ToString()는 숫자를 문자열로 바꿔주는 함수
        }

        
    }
}
