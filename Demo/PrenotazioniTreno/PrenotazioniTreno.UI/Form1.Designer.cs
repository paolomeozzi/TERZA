namespace PrenotazioniTreno.UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroVagone = new System.Windows.Forms.TextBox();
            this.txtPostiPrenotati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrenota = new System.Windows.Forms.Button();
            this.lstTreno = new System.Windows.Forms.ListBox();
            this.lblIntestazioneTreno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrenota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPostiPrenotati);
            this.groupBox1.Controls.Add(this.txtNumeroVagone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(266, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenotazione";
            // 
            // txtNumeroVagone
            // 
            this.txtNumeroVagone.Location = new System.Drawing.Point(19, 67);
            this.txtNumeroVagone.Name = "txtNumeroVagone";
            this.txtNumeroVagone.Size = new System.Drawing.Size(69, 29);
            this.txtNumeroVagone.TabIndex = 0;
            this.txtNumeroVagone.TextChanged += new System.EventHandler(this.txtNumeroVagone_TextChanged);
            // 
            // txtPostiPrenotati
            // 
            this.txtPostiPrenotati.Location = new System.Drawing.Point(171, 67);
            this.txtPostiPrenotati.Name = "txtPostiPrenotati";
            this.txtPostiPrenotati.Size = new System.Drawing.Size(69, 29);
            this.txtPostiPrenotati.TabIndex = 1;
            this.txtPostiPrenotati.TextChanged += new System.EventHandler(this.txtPostiPrenotati_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° vagone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° posti";
            // 
            // btnPrenota
            // 
            this.btnPrenota.Location = new System.Drawing.Point(20, 116);
            this.btnPrenota.Name = "btnPrenota";
            this.btnPrenota.Size = new System.Drawing.Size(220, 37);
            this.btnPrenota.TabIndex = 2;
            this.btnPrenota.Text = "Prenota";
            this.btnPrenota.UseVisualStyleBackColor = true;
            this.btnPrenota.Click += new System.EventHandler(this.btnPrenota_Click);
            // 
            // lstTreno
            // 
            this.lstTreno.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTreno.FormattingEnabled = true;
            this.lstTreno.ItemHeight = 22;
            this.lstTreno.Location = new System.Drawing.Point(372, 57);
            this.lstTreno.Name = "lstTreno";
            this.lstTreno.Size = new System.Drawing.Size(363, 246);
            this.lstTreno.TabIndex = 1;
            // 
            // lblIntestazioneTreno
            // 
            this.lblIntestazioneTreno.AutoSize = true;
            this.lblIntestazioneTreno.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntestazioneTreno.Location = new System.Drawing.Point(369, 27);
            this.lblIntestazioneTreno.Name = "lblIntestazioneTreno";
            this.lblIntestazioneTreno.Size = new System.Drawing.Size(190, 22);
            this.lblIntestazioneTreno.TabIndex = 2;
            this.lblIntestazioneTreno.Text = "Informazioni treno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 325);
            this.Controls.Add(this.lblIntestazioneTreno);
            this.Controls.Add(this.lstTreno);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Prenotazione terno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrenota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostiPrenotati;
        private System.Windows.Forms.TextBox txtNumeroVagone;
        private System.Windows.Forms.ListBox lstTreno;
        private System.Windows.Forms.Label lblIntestazioneTreno;
    }
}

