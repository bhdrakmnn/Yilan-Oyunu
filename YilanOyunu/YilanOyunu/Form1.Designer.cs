namespace YilanOyunu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timerYilanHareket = new System.Windows.Forms.Timer(this.components);
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Location = new System.Drawing.Point(7, 84);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(400, 360);
            this.pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puan: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.ForeColor = System.Drawing.Color.White;
            this.lblPuan.Location = new System.Drawing.Point(55, 40);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(18, 19);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(318, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Süre:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.ForeColor = System.Drawing.Color.White;
            this.lblSure.Location = new System.Drawing.Point(360, 40);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(18, 19);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "0";
            // 
            // timerYilanHareket
            // 
            this.timerYilanHareket.Tick += new System.EventHandler(this.timerYilanHareket_Tick);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(414, 456);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timerYilanHareket;
        private System.Windows.Forms.Timer timerSaat;
    }
}

