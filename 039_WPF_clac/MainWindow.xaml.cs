using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _039_WPF_clac
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private double saved = 0;
        private string op;
        private bool opFlag = false;
        private double memory = 0;
        public MainWindow()
        {
            InitializeComponent();
            btnMR.IsEnabled = false;
            btnMC.IsEnabled = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;//sender는 방금 클릭 된 버튼을 의미
            //Button btn = sender as Button;// 위 코드와 똑같은 역할
            if (txtResult.Text == "0" || opFlag == true)
            {
                txtResult.Text = btn.Content as String;
                opFlag = false;
            }
            else
                txtResult.Text += btn.Content as String;
        }

        //소수점 버튼
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!txtResult.Text.Contains(".")) // == false
            {
                txtResult.Text += ".";
            }
        }

        private void btPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (-double.Parse(txtResult.Text)).ToString();
        }

        //이항 연산자 버튼
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            //(1) 결과창의 숫자를 saved에 저장
            //(2) 연산자를 op에 저장
            //(3) opFlag를 true로 만든다-> 숫자가 처음부터 새로 써진다
            saved = double.Parse(txtResult.Text);
            Button btn = sender as Button;
            op = (string)btn.Content;
            opFlag = true;

            txtExp.Text = txtResult.Text + op;
        }

        // = 버튼
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += txtResult.Text + "=";
            switch (op)
            {
                case "+":
                    txtResult.Text = (saved + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (saved - double.Parse(txtResult.Text)).ToString();
                    break;
                case "×":
                    txtResult.Text = (saved * double.Parse(txtResult.Text)).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        //1/x(역수)버튼
        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtExp.Text = "1/(" + txtResult.Text + ")";
            }
            else
                txtExp.Text = "1/(" + txtResult.Text + ")";
            txtResult.Text = (1.0 / double.Parse(txtResult.Text)).ToString();
            //double x = double.Parse(txtResult.Text);
            //double y = 1/x;
            //txtResult.Text = y.ToString
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtExp.Text = "sqr(" + txtResult.Text + ")";
            }
            else
                txtExp.Text = "sqr(" + txtResult.Text + ")";

            double x = double.Parse(txtResult.Text);
            txtResult.Text = (x * x).ToString();
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtExp.Text = "√(" + txtResult.Text + ")";
            }
            else
                txtExp.Text = "√(" + txtResult.Text + ")";
            double x = double.Parse(txtResult.Text);
            txtResult.Text = Math.Sqrt(x).ToString();
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saved = 0;
            op = "";
            opFlag = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if(txtResult.Text.Length == 0)
            {
                txtResult.Text = "0";
            }
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
        }

        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = memory.ToString();
        }

        private void btnMPlus_Click(object sender, RoutedEventArgs e)
        {
            memory += double.Parse(txtResult.Text);
        }

        private void btnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
        }

        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(txtResult.Text);
            btnMC.IsEnabled = true;
            btnMR.IsEnabled = true;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
