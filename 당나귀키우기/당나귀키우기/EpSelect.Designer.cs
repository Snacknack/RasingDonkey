namespace 당나귀키우기
{
    partial class EpSelect
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
            this.Exit = new System.Windows.Forms.Button();
            this.Tracking = new System.Windows.Forms.Timer(this.components);
            this.DonkeyFarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(147, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Text = "닫기";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Tracking
            // 
            this.Tracking.Interval = 1;
            this.Tracking.Tick += new System.EventHandler(this.Tracking_Tick);
            // 
            // DonkeyFarm
            // 
            this.DonkeyFarm.Location = new System.Drawing.Point(14, 49);
            this.DonkeyFarm.Name = "DonkeyFarm";
            this.DonkeyFarm.Size = new System.Drawing.Size(90, 40);
            this.DonkeyFarm.TabIndex = 1;
            this.DonkeyFarm.TabStop = false;
            this.DonkeyFarm.Text = "당나귀 목장";
            this.DonkeyFarm.UseVisualStyleBackColor = true;
            this.DonkeyFarm.Click += new System.EventHandler(this.DonkeyFarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "탐험 목록";
            // 
            // EpSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DonkeyFarm);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EpSelect";
            this.Text = "EpSelect";
            this.Load += new System.EventHandler(this.EpSelect_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EpSelect_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EpSelect_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer Tracking;
        private System.Windows.Forms.Button DonkeyFarm;
        private System.Windows.Forms.Label label1;
    }
}