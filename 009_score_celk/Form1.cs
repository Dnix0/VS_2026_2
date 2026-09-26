using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_score_celk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(txtKR.Text) + Convert.ToDouble(txtMT.Text) + Convert.ToDouble(txtENG.Text);//국어, 수학, 영어 점수를 더하여 sum 변수에 저장

            double avg = sum / 3;
            txtSUM.Text = sum.ToString();
            txtAVG.Text = avg.ToString("0.0");
        }
    }
}
