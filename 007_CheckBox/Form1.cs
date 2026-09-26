using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkStates = "";// 체크박스들의 상태를 저장할 문자열
            CheckBox[] CB = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };// 체크박스들을 배열로 묶어서 관리

            foreach (var item in CB)//var는 item 변수의 타입을 자동으로 추론, CB 배열의 각 체크박스에 대해 반복
            {
                checkStates += string.Format("{0} : {1}\n", item.Text, item.Checked);// 체크박스의 텍스트와 체크 여부를 문자열에 추가
            }
            MessageBox.Show(checkStates, "checkStates");// 메시지 박스에 어떤 과일들이 체크되어 있는지 보여줌

            string summary = string.Format("좋아하는 과일은 : ");
            foreach(var item in CB)
            {
                if (item.Checked == true)
                {
                    summary += item.Text + " ";
                }
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
