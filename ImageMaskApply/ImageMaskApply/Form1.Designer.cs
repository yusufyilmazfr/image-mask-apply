namespace ImageMaskApply
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
            this.pctrCurrentImageNew = new System.Windows.Forms.PictureBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.pctrCurrentImageOld = new System.Windows.Forms.PictureBox();
            this.trackBarBorderPower = new System.Windows.Forms.TrackBar();
            this.btnSelectAndApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBorderPower)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrCurrentImageNew
            // 
            this.pctrCurrentImageNew.Location = new System.Drawing.Point(333, 12);
            this.pctrCurrentImageNew.Name = "pctrCurrentImageNew";
            this.pctrCurrentImageNew.Size = new System.Drawing.Size(318, 317);
            this.pctrCurrentImageNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrCurrentImageNew.TabIndex = 7;
            this.pctrCurrentImageNew.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(433, 336);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(101, 33);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pctrCurrentImageOld
            // 
            this.pctrCurrentImageOld.Location = new System.Drawing.Point(9, 12);
            this.pctrCurrentImageOld.Name = "pctrCurrentImageOld";
            this.pctrCurrentImageOld.Size = new System.Drawing.Size(318, 317);
            this.pctrCurrentImageOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrCurrentImageOld.TabIndex = 4;
            this.pctrCurrentImageOld.TabStop = false;
            // 
            // trackBarBorderPower
            // 
            this.trackBarBorderPower.Enabled = false;
            this.trackBarBorderPower.Location = new System.Drawing.Point(12, 336);
            this.trackBarBorderPower.Maximum = 50;
            this.trackBarBorderPower.Name = "trackBarBorderPower";
            this.trackBarBorderPower.Size = new System.Drawing.Size(415, 56);
            this.trackBarBorderPower.TabIndex = 8;
            this.trackBarBorderPower.Value = 14;
            // 
            // btnSelectAndApply
            // 
            this.btnSelectAndApply.Location = new System.Drawing.Point(542, 335);
            this.btnSelectAndApply.Name = "btnSelectAndApply";
            this.btnSelectAndApply.Size = new System.Drawing.Size(101, 33);
            this.btnSelectAndApply.TabIndex = 5;
            this.btnSelectAndApply.Text = "Select/Apply";
            this.btnSelectAndApply.UseVisualStyleBackColor = true;
            this.btnSelectAndApply.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 374);
            this.Controls.Add(this.trackBarBorderPower);
            this.Controls.Add(this.pctrCurrentImageNew);
            this.Controls.Add(this.btnSelectAndApply);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pctrCurrentImageOld);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBorderPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrCurrentImageNew;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.PictureBox pctrCurrentImageOld;
        private System.Windows.Forms.TrackBar trackBarBorderPower;
        private System.Windows.Forms.Button btnSelectAndApply;
    }
}

