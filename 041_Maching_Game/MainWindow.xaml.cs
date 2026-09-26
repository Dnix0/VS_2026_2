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
using System.Windows.Threading;

namespace _041_Maching_Game
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] rnd = new int[16];//rnd배열
        private Button first = null;
        private Button second = null;
        private int matched = 0;// 맞춘 그림 갯수
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()// 생성자 메서드
        {
            InitializeComponent();
            Boardset();

            timer.Interval = new TimeSpan(0, 0, 0, 0, 750);//5개를 써줘야 0.75초
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            first.Content = MackeImage("../../Images/check.png");
            second.Content = MackeImage("../../Images/check.png");

            first = null;
            second = null;
        }

        //16개의 버튼을 만들어서 저장한다 board에 넣는다
        private void Boardset()
        {
            for(int i = 0; i < 16; i++)
            {
                Button b = new Button();

                b.Background = Brushes.White;

                b.Margin = new Thickness(10);

                b.Content = MackeImage("../../Images/check.png");//실행파일 기준 위에 위에 이미지스 그 밑에 체크가 있다

                b.Tag = TegSet();

                //클릭 이벤트 등록
                b.Click += B_Click;//b.Click += 하고 TAB

                Board.Children.Add(b);
            }
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;//(Button)sender

            string[] icon = { "딸기", "레몬", "모과", "배", "사과", "수박", "파인애플", "포도" };

            btn.Content = MackeImage("../../Images/" + icon[(int)btn.Tag] + ".png");

            if(first == null)//이 카드가 첫번째 카드라면
            {
                first = btn;//
                return;
            }
            else
            {
                second = btn;
            }

            //두 버튼이 같은지 체트는 Tag로 확인
            if ((int)first.Tag == (int)second.Tag)//매치가 됨
            {
                first = null;
                second = null;
                matched += 2;//16개가 되면끝
                if(matched == 16)
                {
                    MessageBox.Show("성공했습니다!", "Success");
                    this.Close();
                }
            }
            else//매치가 안됬음
            {
                timer.Start();
            }
        }

        private Image MackeImage(string v)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(v, UriKind.Relative);
            bi.EndInit();

            Image img = new Image();
            img.Source = bi;
            img.Margin = new Thickness(10);
            img.Stretch = Stretch.Fill;

            return img;
        }
        private int TegSet()
        {
            int i;
            Random r = new Random();

            while (true)
            {
                i = r.Next(16);//0~15
                if (rnd[i] == 0)//숫자가 처음 나왔으면
                {
                    rnd[i] = 1;// 이미 나왔다고 표시
                    break;
                }
            }

            return i % 8;//태그는 0~7까지 8개의 그림을 표시
        }
    }
}
