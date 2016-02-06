namespace NetworkConnection
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
            this.lblPisi = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPisi
            // 
            this.lblPisi.AutoSize = true;
            this.lblPisi.Location = new System.Drawing.Point(80, 22);
            this.lblPisi.Name = "lblPisi";
            this.lblPisi.Size = new System.Drawing.Size(57, 13);
            this.lblPisi.TabIndex = 0;
            this.lblPisi.Text = "Interfaces:";
            // 
            // tmTime
            // 
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // zg1
            // 
            this.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg1.Location = new System.Drawing.Point(83, 82);
            this.zg1.Name = "zg1";
            this.zg1.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(499, 333);
            this.zg1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(439, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 437);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.lblPisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPisi;
        private System.Windows.Forms.Timer tmTime;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

