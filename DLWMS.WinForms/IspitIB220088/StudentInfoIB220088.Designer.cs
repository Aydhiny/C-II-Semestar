namespace DLWMS.WinForms.IspitIB220088
{
    partial class StudentInfoIB220088
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
            pcbSlika = new PictureBox();
            lblIme = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbSlika).BeginInit();
            SuspendLayout();
            // 
            // pcbSlika
            // 
            pcbSlika.Location = new Point(12, 12);
            pcbSlika.Name = "pcbSlika";
            pcbSlika.Size = new Size(397, 327);
            pcbSlika.TabIndex = 0;
            pcbSlika.TabStop = false;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(175, 365);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(0, 20);
            lblIme.TabIndex = 1;
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(175, 404);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(0, 20);
            lblProsjek.TabIndex = 1;
            // 
            // StudentInfoIB220088
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 522);
            Controls.Add(lblProsjek);
            Controls.Add(lblIme);
            Controls.Add(pcbSlika);
            Name = "StudentInfoIB220088";
            Text = "StudentInfoIB220088";
            ((System.ComponentModel.ISupportInitialize)pcbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbSlika;
        private Label lblIme;
        private Label lblProsjek;
    }
}