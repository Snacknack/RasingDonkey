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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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
            Refresh(sender, e);
        }

        private void Refresh(object sender , EventArgs e) // 새로고침
        {
            GoldLabel.Text = "골드 : " + Data.Class1.Gold + "원";
        }

        private void OpenFile(object sender, EventArgs e)
        {
            FileStream OpenData = new FileStream("DataFile.dat", FileMode.Open);
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
}
