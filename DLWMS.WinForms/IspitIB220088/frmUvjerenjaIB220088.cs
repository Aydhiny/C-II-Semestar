using DLWMS.Data;
using DLWMS.Data.IspitIB220088;
using DLWMS.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB220088
{
    public partial class frmUvjerenjaIB220088 : Form
    {
        List<StudentiUvjerenjaIB220088> podaci = new List<StudentiUvjerenjaIB220088>();
        DLWMSDbContext db = new DLWMSDbContext();
        private int id;

        public frmUvjerenjaIB220088(int id)
        {
            this.id = id;
            InitializeComponent();
            dgvUvjerenja.AutoGenerateColumns = false;
            ucitajVrste();
            UcitajUvjerenja();
        }

        private void ucitajVrste()
        {
            List<string> list = new List<string>();
            list.Add("Uvjerenje o statusu studenta");
            list.Add("Uvjerenje o položenim ispitima");
            list.Add("Uvjerenje o prosjeku studenta");
            cmbVrsta.DataSource = list;
        }

        private void frmUvjerenjaIB220088_Load(object sender, EventArgs e)
        {
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            podaci = db.StudentiUvjerenjaIB220088.Include("Student").Where(x => x.StudentId == id).ToList();
            if (podaci.Count > 0)
            {
                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = podaci;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int brojUvjerenja;
            try
            {
                brojUvjerenja = int.Parse(txtBroj.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nije unesen broj u textBox broj zahtjeva!!!!!!");
                return;
            }
            txtInfo.ScrollBars = ScrollBars.Vertical;
            var vrsta = cmbVrsta.SelectedItem.ToString();
            var svrha = txtSvrha.Text;
            var slika = db.StudentiUvjerenjaIB220088.First().Uplatnica;

            var t1 = new Thread(() => DodajUvjerenje(brojUvjerenja, svrha, vrsta, slika));

            t1.Start();
        }

        private void DodajUvjerenje(int brojUvjerenja, string svrha, string vrsta, byte[] slika)
        {
           // var podaci = db.Studenti.Where(x => x.Id == id).ToList();
            for (int i = 0; i < brojUvjerenja; i++)
            {
                var novaTabl = new StudentiUvjerenjaIB220088()
                {
                    StudentId = id,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Printano = false,
                    Uplatnica = slika,
                    Datum = DateTime.Now,
                };
                db.StudentiUvjerenjaIB220088.Add(novaTabl);
                db.SaveChanges();
                Action ac = () =>
                {
                    txtInfo.Text += $"{novaTabl.Datum.ToLongTimeString()} -> {novaTabl.Vrsta} ({novaTabl.Student.BrojIndeksa})" +
                    $" - {novaTabl.Student.Ime} {novaTabl.Student.Prezime} u svrrhu {novaTabl.Svrha}" + Environment.NewLine;
                    SetCursor();
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            MessageBox.Show($"Uspjesno dodato {brojUvjerenja} uvjerenja");
            BeginInvoke(UcitajUvjerenja);
        }
        private void SetCursor()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frm = new frmNovoUvjerenjeIB220088(id);
            if (frm.ShowDialog() == DialogResult.OK)
                UcitajUvjerenja();
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == dgvUvjerenja.ColumnCount - 1) 
            {
                var uvjerenje = podaci[e.RowIndex];
                var frm = new frmIzvjestaji(uvjerenje);
                podaci[e.RowIndex].Printano = true;
                db.SaveChanges();
                frm.Show();
                UcitajUvjerenja();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvUvjerenja.ColumnCount - 2) 
            {
                var brisanoUvjerenje = dgvUvjerenja.Rows[e.RowIndex].DataBoundItem as StudentiUvjerenjaIB220088;
                db.StudentiUvjerenjaIB220088.Remove(brisanoUvjerenje);
                db.SaveChanges();
                UcitajUvjerenja();
            }
        }
    }
}
