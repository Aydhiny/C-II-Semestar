namespace DLWMS.WinForms.IspitIB220088
{
    partial class frmUvjerenjaIB220088
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
            dgvUvjerenja = new DataGridView();
            btnDodaj = new Button();
            btnSacuvaj = new Button();
            txtInfo = new TextBox();
            txtBroj = new TextBox();
            txtSvrha = new TextBox();
            cmbVrsta = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Vrsta = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            SuspendLayout();
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Vrsta, Datum, Svrha, Printano, Uplatnica, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 68);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.RowTemplate.Height = 29;
            dgvUvjerenja.Size = new Size(776, 188);
            dgvUvjerenja.TabIndex = 0;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(658, 33);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 29);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj Uvjerenje";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(656, 292);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(130, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sacuvaj =>";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(22, 359);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(766, 141);
            txtInfo.TabIndex = 2;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(527, 294);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(114, 27);
            txtBroj.TabIndex = 2;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(177, 294);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(344, 27);
            txtSvrha.TabIndex = 2;
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Location = new Point(20, 294);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(151, 28);
            cmbVrsta.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 271);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 271);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 4;
            label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 271);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Vrsta:";
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Resizable = DataGridViewTriState.True;
            Uplatnica.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.DataPropertyName = "Brisi";
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.DataPropertyName = "Printaj";
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // frmUvjerenjaIB220088
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbVrsta);
            Controls.Add(txtSvrha);
            Controls.Add(txtBroj);
            Controls.Add(txtInfo);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnDodaj);
            Controls.Add(dgvUvjerenja);
            Name = "frmUvjerenjaIB220088";
            Text = "frmUvjerenjaIB220088";
            Load += frmUvjerenjaIB220088_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUvjerenja;
        private Button btnDodaj;
        private Button btnSacuvaj;
        private TextBox txtInfo;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private ComboBox cmbVrsta;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
    }
}