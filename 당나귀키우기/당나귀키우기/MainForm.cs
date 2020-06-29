using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
//using WMPLib;

namespace 당나귀키우기
{
    public partial class MainForm : Form
    {
        //WindowsMediaPlayer windowsmediaplayer = new WindowsMediaPlayer();
        public MainForm()
        {
            InitializeComponent();
            Refresh.Enabled = true;
            if (File.Exists("Background.dmp"))
            {
                //windowsmediaplayer.URL = "Background.dmp";
                //trackBar1.Value = Data.Class1.Volume;
            }
            
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // 종료될때 자동 저장
        {
            FileStream SaveData = new FileStream("DataFile.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(SaveData, Data.Class1.Gold);
                formatter.Serialize(SaveData, Data.Class1.Exp);
                formatter.Serialize(SaveData, Data.Class1.Level);
                formatter.Serialize(SaveData, Data.Class1.RequiredExp);
                formatter.Serialize(SaveData, Data.Class1.Volume);
                formatter.Serialize(SaveData, Data.Class4.item1);
            }
            catch
            {
                MessageBox.Show("저장 실패");
            }
            finally
            {
                SaveData.Close();
            }
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenFile(sender, e);
            //windowsmediaplayer.controls.play();
            
            

        }







        private void OpenFile(object sender, EventArgs e) // 불러오기
        {
            if (File.Exists("DataFile.dat"))
            {
                FileStream OpenData = new FileStream("DataFile.dat", FileMode.Open);

                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Data.Class1.Gold = Convert.ToInt32(formatter.Deserialize(OpenData));
                    Data.Class1.Exp = Convert.ToInt32(formatter.Deserialize(OpenData));
                    Data.Class1.Level = Convert.ToInt32(formatter.Deserialize(OpenData));
                    Data.Class1.RequiredExp = Convert.ToInt32(formatter.Deserialize(OpenData));
                    Data.Class1.Volume = Convert.ToInt32(formatter.Deserialize(OpenData));
                    Data.Class4.item1 = Convert.ToInt32(formatter.Deserialize(OpenData));

                }
                catch
                {
                    Console.WriteLine("파일 불러오기 실패");
                
                }
                finally
                {

                    OpenData.Close();
                }
            }
        }

        private void Inv_Click(object sender, EventArgs e)
        {
            Inv inv = new Inv();
            if (Data.Class2.InvIsOpened == false)
            {
                inv.Show();
                inv.Location = new Point(this.Location.X + 10 , this.Bottom - this.Location.Y + 200);
                Data.Class2.InvIsOpened = true;
            }
        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
          
                if (Class1.Exp > Class1.RequiredExp) 
                {
                    Data.Class1.Level++;
                    Class1.Exp -= Class1.RequiredExp;
                    Data.Class1.RequiredExp += 5 ;
                }
                else if(Data.Class1.Exp == Data.Class1.RequiredExp)
                {
                    Data.Class1.Level++;
                    Data.Class1.Exp = 0;
                    Data.Class1.RequiredExp += 5;
                 }
            
           // Data.Class1.Volume = //trackBar1.Value;
            //Volume.Text = "음량 : " + Data.Class1.Volume;
           // windowsmediaplayer.settings.volume = Data.Class1.Volume;
                
          
            ExpProgressBar.Style = ProgressBarStyle.Continuous;
                ExpProgressBar.Maximum = Data.Class1.RequiredExp;
                ExpProgressBar.Value = Data.Class1.Exp;
            GoldLabel.Text = "골드 : " + Data.Class1.Gold + "원";
            LvLabel.Text = "레벨 : " + Data.Class1.Level;
            ExpLabel.Text = "경험치 : " + Data.Class1.Exp + "/" + Data.Class1.RequiredExp;
            NameBox.Text = "사용자 : " +  Data.Class3.Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Class1.Exp++;
        }

        private void ExpProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void WriteLog_Tick(object sender, EventArgs e)
        {
            if (Data.Class3.LogOnOff)
            {
                LogList.Text += Data.Class3.Log + "\r\n";
                Data.Class3.Log = "";
                this.LogList.SelectionStart = LogList.Text.Length;
                this.LogList.ScrollToCaret();

      
                Data.Class3.LogOnOff = false;
            }      

        }

        private void Adventure_Click_1(object sender, EventArgs e)
        {
            EpSelect epselect = new EpSelect();
            if (Data.Class2.EpStIsOpened == false)
            {
                epselect.Show();
                epselect.Location = new Point(this.Location.X + 280, this.Location.Y + 100);
                Data.Class2.EpStIsOpened = true;
            }
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            if (Data.Class2.ShopIsOpened == false)
            {
                shop.Show();
                shop.Location = new Point(this.Location.X, this.Location.Y);
                Data.Class2.ShopIsOpened = true;
            }   
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
