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
            this.GoldLabel = new System.Windows.Forms.Label();
            this.Inv = new System.Windows.Forms.Button();
            this.ExpProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.LvLabel = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.Adventure = new System.Windows.Forms.Button();
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
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Enabled = true;
            this.ProgressBarTimer.Interval = 1;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.ProgressBarTimer_Tick);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Adventure);
            this.Controls.Add(this.LvLabel);
            this.Controls.Add(this.ExpLabel);
            this.Controls.Add(this.ExpProgressBar);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.GoldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.Button Adventure;
    }
}