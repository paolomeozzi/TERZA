namespace DemoDragDrop
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
            this.picGiallo = new System.Windows.Forms.PictureBox();
            this.picRosso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGiallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRosso)).BeginInit();
            this.SuspendLayout();
            // 
            // picGiallo
            // 
            this.picGiallo.Location = new System.Drawing.Point(268, 229);
            this.picGiallo.Name = "picGiallo";
            this.picGiallo.Size = new System.Drawing.Size(96, 83);
            this.picGiallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGiallo.TabIndex = 0;
            this.picGiallo.TabStop = false;
            // 
            // picRosso
            // 
            this.picRosso.Location = new System.Drawing.Point(84, 229);
            this.picRosso.Name = "picRosso";
            this.picRosso.Size = new System.Drawing.Size(96, 83);
            this.picRosso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRosso.TabIndex = 1;
            this.picRosso.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 358);
            this.Controls.Add(this.picRosso);
            this.Controls.Add(this.picGiallo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGiallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRosso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGiallo;
        private System.Windows.Forms.PictureBox picRosso;
    }
}

