using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inNM.Text != "")//이름이 빈칸이 아니면
            {
                outNM.Text = inNM.Text + "님!" + "안녕하세요, ";//outNM에 inNM의 텍스트를 가져와서 "님!안녕하세요, "를 붙여서 출력
            }
            else
            {
               MessageBox.Show("이름을 입력하세요.", "Warning");//빈칸이면 경고창 띄우기
            }
        }
    }
}
