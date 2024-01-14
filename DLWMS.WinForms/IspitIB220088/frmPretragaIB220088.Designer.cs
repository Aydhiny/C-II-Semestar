namespace DLWMS.WinForms.IspitIB220088
{
    partial class frmPretragaIB220088
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
            dateOd = new DateTimePicker();
            dateDo = new DateTimePicker();
            dgvStudenti = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            cmbSpolovi = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dateOd
            // 
            dateOd.Location = new Point(298, 28);
            dateOd.Name = "dateOd";
            dateOd.Size = new Size(250, 27);
            dateOd.TabIndex = 0;
            dateOd.ValueChanged += dateOd_ValueChanged;
            // 
            // dateDo
            // 
            dateDo.Location = new Point(622, 28);
            dateDo.Name = "dateDo";
            dateDo.Size = new Size(250, 27);
            dateDo.TabIndex = 0;
            dateDo.ValueChanged += dateDo_ValueChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Id, BrojIndeksa, ImePrezime, DatumRodjenja, Prosjek, Aktivan, Uvjerenja });
            dgvStudenti.Location = new Point(12, 70);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(913, 284);
            dgvStudenti.TabIndex = 1;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "ImePrezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "DatumRodjenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenja.DataPropertyName = "Uvjerenja";
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // cmbSpolovi
            // 
            cmbSpolovi.FormattingEnabled = true;
            cmbSpolovi.Location = new Point(78, 27);
            cmbSpolovi.Name = "cmbSpolovi";
            cmbSpolovi.Size = new Size(151, 28);
            cmbSpolovi.TabIndex = 2;
            cmbSpolovi.SelectedIndexChanged += cmbSpolovi_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Spol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 33);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "Od:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 35);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 3;
            label3.Text = "Do:";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(12, 374);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 20);
            lblWarning.TabIndex = 3;
            // 
            // frmPretragaIB220088
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 431);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWarning);
            Controls.Add(label1);
            Controls.Add(cmbSpolovi);
            Controls.Add(dgvStudenti);
            Controls.Add(dateDo);
            Controls.Add(dateOd);
            Name = "frmPretragaIB220088";
            Text = "frmPretragaIB220088";
            Load += frmPretragaIB220088_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateOd;
        private DateTimePicker dateDo;
        private DataGridView dgvStudenti;
        private ComboBox cmbSpolovi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblWarning;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}