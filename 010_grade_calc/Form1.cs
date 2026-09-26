using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _010_grade_calc
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "설계및 프로젝트 심화";
            txt3.Text = "전기전자공학및 실험";
            txt4.Text = "창의력 개발과정";
            txt5.Text = "비주얼프로그래밍";
            txt6.Text = "기업가정신과 리더십";

            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };
            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach (var combo in crds)
            {
                foreach (var i in arrCredit)
                {
                    combo.Items.Add(i);
                }
                combo.SelectedItem = 3;
            }

            foreach (var combo in grds)
            {
                foreach (var grd in lstGrade)
                {
                    combo.Items.Add(grd);
                }
                combo.SelectedItem = "A0";   // 기본값 설정
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredit = 0;

            for (int i = 0; i < crds.Length; i++)// crds 배열의 길이만큼 반복
            {
                if (titles[i].Text != "")// 과목명이 비어있지 않은 경우
                {
                    int crd = int.Parse(crds[i].Text);// i번째 입력받은 학점을 정수로 변환하여 crd 변수에 저장
                    //int crd = int.Parse(crds[i].SelectedItem.ToString());
                    string grd = grds[i].SelectedItem.ToString();//.SelectedItem은 선택된 항목 = "A0" 등

                    totalCredit += crd;
                    //totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
                    totalScore += crd * GetGrade(grds[i].Text);
                }
            }
            result.Text = (totalScore / totalCredit).ToString("0.00");
        }

        private double GetGrade(string text)
        {
            double grade = 0;
            if (text == "A+")
                grade = 4.5;
            else if (text == "A0")
                grade = 4.0;
            else if (text == "B+")
                grade = 3.5;
            else if (text == "B0")
                grade = 3.0;
            else if (text == "C+")
                grade = 2.5;
            else if (text == "C0")
                grade = 2.0;
            else if (text == "D+")
                grade = 1.5;
            else if (text == "D0")
                grade = 1.0;
            else
                grade = 0;   // F 또는 예외 처리
            return grade;
        }
    }
}