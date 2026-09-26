using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_LableMulti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//버튼을 누르면
        {
            txtEP.Text = "건양대학교는 1991년에 개교한 사립 종합대학교입니다.";//텍스트 출력
            txtEP2.Text = "건양대학교는 대전광역시 유성구에 위치한 종합대학교입니다. 1991년에 개교하였으며, 현재는 10개�� 단과대학과 대학원으로 구성되어 있습니다. 건양대학교는 교육과 연구에 대한 높은 수준의 역량을 갖추고 있으며, 국내외에서 인정받는 대학 중 하나입니다.";
        }
    }
}
