using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace 당나귀키우기
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            Refresh.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // 종료될때 자동 저장
        {
            FileStream SaveData = new FileStream("DataFile.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(SaveData, Data.Class1.Gold);
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
        }

    
        
            
        

        private void OpenFile(object sender, EventArgs e) // 불러오기
        {
            FileStream OpenData = new FileStream("DataFile.dat", FileMode.Open);
            if(!(OpenData == null))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Data.Class1.Gold = Convert.ToInt32(formatter.Deserialize(OpenData));

                }
                catch
                {
                    Console.WriteLine("파일 불러오기 실패");
                    throw;
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
            ExpProgressBar.Style = ProgressBarStyle.Continuous;
            ExpProgressBar.Maximum = Data.Class1.RequiredExp;
            ExpProgressBar.Value = Data.Class1.Exp;
            if(Data.Class1.Exp == Data.Class1.RequiredExp)
            {
                Data.Class1.Level++;
                Data.Class1.Exp = 0;
                Data.Class1.RequiredExp += 5;
            }
            GoldLabel.Text = "골드 : " + Data.Class1.Gold + "원";
            LvLabel.Text = "레벨 : " + Data.Class1.Level;
            ExpLabel.Text = "경험치 : " + Data.Class1.Exp + "/" + Data.Class1.RequiredExp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Class1.Exp++;
        }
    }
}
