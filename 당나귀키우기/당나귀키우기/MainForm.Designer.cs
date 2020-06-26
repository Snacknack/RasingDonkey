namespace 당나귀키우기
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GoldLabel = new System.Windows.Forms.Label();
            this.Inv = new System.Windows.Forms.Button();
            this.ExpProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.LvLabel = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            this.WriteLog = new System.Windows.Forms.Timer(this.components);
            this.Adventure = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.LogList = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.Location = new System.Drawing.Point(12, 9);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(41, 12);
            this.GoldLabel.TabIndex = 0;
            this.GoldLabel.Text = "골드 : ";
            // 
            // Inv
            // 
            this.Inv.Location = new System.Drawing.Point(12, 346);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(75, 50);
            this.Inv.TabIndex = 1;
            this.Inv.Text = "인벤토리";
            this.Inv.UseVisualStyleBackColor = true;
            this.Inv.Click += new System.EventHandler(this.Inv_Click);
            // 
            // ExpProgressBar
            // 
            this.ExpProgressBar.Location = new System.Drawing.Point(14, 426);
            this.ExpProgressBar.Name = "ExpProgressBar";
            this.ExpProgressBar.Size = new System.Drawing.Size(758, 23);
            this.ExpProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ExpProgressBar.TabIndex = 0;
            this.ExpProgressBar.Click += new System.EventHandler(this.ExpProgressBar_Click);
            // 
            // ExpLabel
            // 
            this.ExpLabel.AutoSize = true;
            this.ExpLabel.Location = new System.Drawing.Point(12, 411);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(53, 12);
            this.ExpLabel.TabIndex = 3;
            this.ExpLabel.Text = "경험치 : ";
            // 
            // LvLabel
            // 
            this.LvLabel.AutoSize = true;
            this.LvLabel.Location = new System.Drawing.Point(12, 38);
            this.LvLabel.Name = "LvLabel";
            this.LvLabel.Size = new System.Drawing.Size(41, 12);
            this.LvLabel.TabIndex = 4;
            this.LvLabel.Text = "레벨 : ";
            // 
            // Refresh
            // 
            this.Refresh.Interval = 1;
            this.Refresh.Tick += new System.EventHandler(this.Refresh_Tick);
            // 
            // WriteLog
            // 
            this.WriteLog.Enabled = true;
            this.WriteLog.Interval = 1;
            this.WriteLog.Tick += new System.EventHandler(this.WriteLog_Tick);
            // 
            // Adventure
            // 
            this.Adventure.Location = new System.Drawing.Point(697, 19);
            this.Adventure.Name = "Adventure";
            this.Adventure.Size = new System.Drawing.Size(75, 50);
            this.Adventure.TabIndex = 5;
            this.Adventure.Text = "탐험";
            this.Adventure.UseVisualStyleBackColor = true;
            this.Adventure.Click += new System.EventHandler(this.Adventure_Click_1);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(93, 346);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(75, 50);
            this.ShopBtn.TabIndex = 0;
            this.ShopBtn.TabStop = false;
            this.ShopBtn.Text = "상점";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // LogList
            // 
            this.LogList.Location = new System.Drawing.Point(14, 69);
            this.LogList.Multiline = true;
            this.LogList.Name = "LogList";
            this.LogList.ReadOnly = true;
            this.LogList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogList.Size = new System.Drawing.Size(154, 168);
            this.LogList.TabIndex = 6;
            this.LogList.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 265);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 25;
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(12, 250);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(41, 12);
            this.Volume.TabIndex = 9;
            this.Volume.Text = "음량 : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LogList);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.Adventure);
            this.Controls.Add(this.LvLabel);
            this.Controls.Add(this.ExpLabel);
            this.Controls.Add(this.ExpProgressBar);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.GoldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "당나귀 키우기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.Button Inv;
        private System.Windows.Forms.ProgressBar ExpProgressBar;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.Label LvLabel;
        private System.Windows.Forms.Timer Refresh;
        private System.Windows.Forms.Timer WriteLog;
        private System.Windows.Forms.Button Adventure;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.TextBox LogList;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label Volume;
    }
}