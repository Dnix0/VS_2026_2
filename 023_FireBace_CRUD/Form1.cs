using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.Xml.Linq;

namespace _023_FireBace_CRUD
{
    public partial class Form1 : Form
    {
        //IFirebaseConfig config = new FirebaseConfig//설정
        IFirebaseConfig config = new FirebaseConfig
	{
    		// Security: insert your own Firebase configuration locally.
    		AuthSecret = "YOUR_FIREBASE_DATABASE_SECRET",
    		BasePath = "YOUR_FIREBASE_DATABASE_URL"
	};

        IFirebaseClient client;//데이터 베이스의 클라이언트 만들기

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("C#에서 Firebase 데이터베이스를 대행하는 client 생성!");
            }
            try
            {
                var r = client.Set("연결 test", "OK");
                MessageBox.Show("연결성공");
            }
            catch(Exception ex)
            {
                MessageBox.Show("연결실패", ex.Message);
            }
        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
                return;
            var data = new Data
            {
                Id = txt_ID.Text,
                SID = txt_SId.Text,
                Name = txt_Name.Text,
                Phone = txt_Phone.Text
            };

            SetResponse r = await client.SetAsync("SampleData/" + txt_ID, data);
            Data result = r.ResultAs<Data>();
            MessageBox.Show("Insert : Id = " + result.Id);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Phone.Text = string.Empty;
            txt_SId.Text = string.Empty;
        }
    }
}

