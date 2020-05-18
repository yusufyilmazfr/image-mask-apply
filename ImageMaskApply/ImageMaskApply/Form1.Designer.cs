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
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.pctrCurrentImageOld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageOld)).BeginInit();
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
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(9, 336);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(0, 17);
            this.lblImageName.TabIndex = 6;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(550, 335);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(101, 33);
            this.btnOpenFileDialog.TabIndex = 5;
            this.btnOpenFileDialog.Text = "Select Image";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 374);
            this.Controls.Add(this.pctrCurrentImageNew);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.pctrCurrentImageOld);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCurrentImageOld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrCurrentImageNew;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.PictureBox pctrCurrentImageOld;
    }
}

