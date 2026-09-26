using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_RadioButton
{
    public partial class Form1 : Form
    {
        private RadioButton checkedRB;//checkedRB 라디오 버튼을 저장하는 변수 선언
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";// result 변수 초기화
            if (rbKR.Checked)// rbKR 라디오 버튼이 선택된 경우
            {
                result += "국적 : 대한민국\n";// result 변수에 "국적 : 대한민국\n" 문자열 추가
            }
            else if (rbCN.Checked)// rbCN 라디오 버튼이 선택된 경우
            {
                result += "국적 : 중국\n";// result 변수에 "국적 : 중국\n" 문자열 추가
            }
            else if (rbJP.Checked)// rbJP 라디오 버튼이 선택된 경우
            {
                result += "국적 : 일본\n";// result 변수에 "국적 : 일본\n" 문자열 추가
            }
            else if (rbOT.Checked)// rbOT 라디오 버튼이 선택된 경우
            {
                result += "국적 : 그 외의 국가\n";// result 변수에 "국적 : 그 외의 국가\n" 문자열 추가
            }

            if (checkedRB == rbM)// checkedRB 변수가 rbM 라디오 버튼과 같은 경우
            {
                result += "성별 : 남성\n";// result 변수에 "성별 : 남성\n" 문자열 추가
            }
            else if (checkedRB == rbFM)
            {
                result += "성별 : 여성\n";
            }

            MessageBox.Show(result, "result");
        }


        private void rbM_CheckedChanged_1(object sender, EventArgs e)// rbM 라디오 버튼이 선택된 경우
        {
            checkedRB = rbM;// checkedRB 변수에 rbM 라디오 버튼을 할당
        }

        private void rbFM_CheckedChanged(object sender, EventArgs e)// rbFM 라디오 버튼이 선택된 경우
        {
            checkedRB = rbFM;// checkedRB 변수에 rbFM 라디오 버튼을 할당
        }
    }
}
