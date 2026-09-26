using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_messageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("가장 간단한 메시지박스입니다.");// 가장 간단한 메시지 박스입니다.

            MessageBox.Show("타이틀을 갖는 메시지 박스입니다.", "Title massage");//메시지 박스위에 타이틀 추가

            MessageBox.Show("느낌표와 알람 메시지 박스입니다.", "느낌표와 알람 소리", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// 느낌표 아이콘과 알람 소리를 갖는 메시지 박스입니다.

            DialogResult result = MessageBox.Show("두개의 버튼을 갖는 메시지 박스입니다.", "Question", MessageBoxButtons.YesNo);//DialogResult 메시지 박스에서 사용자가 선택한 버튼을 저장

            DialogResult result2 = MessageBox.Show("세개의 버튼과 물음표 아이콘을 보여주는 메시지 박스입니다.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            DialogResult result3 = MessageBox.Show("디폴트 버튼을 두번째 버튼으로\n 지정한 메시지 박스입니다.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            string msg = string.Format("당신의 선택 : {0} {1} {2}", result.ToString(), result2.ToString(), result3.ToString());
            MessageBox.Show(msg, "Your Selections");
        }
    }
}
