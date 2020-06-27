using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 당나귀키우기
{
    public partial class First : Form
    {
        public static string[] ID = new string[2];
        public static string[] PW = new string[2];

        public static int Loggedin = 0;
        public static int ServerOnOff = 0;
        public First()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            GetHtmlString();
            if (!(ServerOnOff == 1))
            {
                for (int i = 0; i < ID.Length; i++)
                {
                    if (IdBox.Text == ID[i] && PwBox.Text == PW[i])
                    {
                        MainForm mainform = new MainForm();
                        this.Hide();
                        Data.Class3.Username = ID[i];
                        mainform.Show();
                        MessageBox.Show(Data.Class3.Username + "님 반갑습니다");
                        Loggedin = 1;
                        continue;
                    }
                    
                }
                if (Loggedin == 0)
                {
                    MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.");
                }
               

            }
            else
            {
                MessageBox.Show("서버가 작동 중이지 않습니다");
            }
            

        }

        private void First_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void First_Load(object sender, EventArgs e)
        {
           

        }
        private void GetHtmlString(string url = "http://www.rasingdonkey.kro.kr/")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
             
                for(int i = 0; i<ID.Length; i++) {
                    ID[i] = reader.ReadLine();                   
                    PW[i] = reader.ReadLine();                  
                }
                
                
               // label2.Text = "id : "+ ID + Environment.NewLine + "pw : " + PW; 

                reader.Close();
                response.Close();
            }
            catch {
                ServerOnOff = 1;
            }
         
        }

        private void PwBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            
        }

        private void IdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                button1_Click(sender, e);
                }
        }
    }
}
