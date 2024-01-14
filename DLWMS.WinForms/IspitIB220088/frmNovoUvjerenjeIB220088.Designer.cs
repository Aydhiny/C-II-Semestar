namespace DLWMS.WinForms.IspitIB220088
{
    partial class frmNovoUvjerenjeIB220088
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
            components = new System.ComponentModel.Container();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            pcbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            cmbVrsta = new ComboBox();
            txtSvrha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUplatnica).BeginInit();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pcbUplatnica
            // 
            pcbUplatnica.Location = new Point(309, 30);
            pcbUplatnica.Name = "pcbUplatnica";
            pcbUplatnica.Size = new Size(695, 286);
            pcbUplatnica.TabIndex = 0;
            pcbUplatnica.TabStop = false;
            pcbUplatnica.DoubleClick += pcbUplatnica_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(910, 333);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(12, 30);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(282, 28);
            cmbVrsta.TabIndex = 2;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(12, 64);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(282, 252);
            txtSvrha.TabIndex = 3;
            // 
            // frmNovoUvjerenjeIB220088
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 384);
            Controls.Add(txtSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(btnSacuvaj);
            Controls.Add(pcbUplatnica);
            Name = "frmNovoUvjerenjeIB220088";
            Text = "frmNovoUvjerenjeIB220088";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUplatnica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider err;
        private TextBox txtSvrha;
        private ComboBox cmbVrsta;
        private Button btnSacuvaj;
        private PictureBox pcbUplatnica;
        private OpenFileDialog openFileDialog1;
    }
}