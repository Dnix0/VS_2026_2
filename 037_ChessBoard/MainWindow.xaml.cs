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

namespace _037_ChessBoard
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChessBoard.Rows = 8;
            ChessBoard.Columns = 8;

            for(int i = 0; i < 64 / 2; i++)
            {
                Rectangle r = new Rectangle();
                r.Fill = Brushes.Black;
                r.Margin = new Thickness(1);

                Rectangle r1 = new Rectangle();
                r1.Fill = Brushes.Red;
                r1.Margin = new Thickness(1);
                if ((i / 4) % 2 == 0)//0,2,4,8번째 줄은 검빨검빨
                {
                    ChessBoard.Children.Add(r);
                    ChessBoard.Children.Add(r1);
                }
                else//나머지는 빨검빨검
                {
                    ChessBoard.Children.Add(r1);
                    ChessBoard.Children.Add(r);
                }
            }
        }
    }
}
