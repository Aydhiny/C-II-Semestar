using DLWMS.Data;
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
    public partial class frmPretragaIB220088 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPretragaIB220088()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            cmbSpolovi.DataSource = db.Spolovi.ToList();
        }

        private void UcitajTabelu()
        {
            DataTable Tabela = new DataTable();
            Tabela.Columns.Add("Id");
            Tabela.Columns.Add("BrojIndeksa");
            Tabela.Columns.Add("DatumRodjenja");
            Tabela.Columns.Add("ImePrezime");
            Tabela.Columns.Add("Prosjek");
            Tabela.Columns.Add("Aktivan");

            var Spolic = cmbSpolovi.SelectedItem as Spol;
            var datumOd = dateOd.Value; var datumDo = dateDo.Value;
            var podaci = db.Studenti.Where(x => x.Spol.Id == Spolic.Id
            && x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo).ToList();
            if (podaci.Count > 0)
            {
                foreach (var student in podaci)
                {
                    var Red = Tabela.NewRow();
                    Red["Id"] = student.Id;
                    Red["BrojIndeksa"] = student.BrojIndeksa;
                    Red["DatumRodjenja"] = student.DatumRodjenja;
                    Red["ImePrezime"] = student.ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString("0.00");
                    Red["Aktivan"] = student.Aktivan;
                    Tabela.Rows.Add(Red);
                }
            }
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = Tabela;
            ProvjeriTabelu();
        }

        private void ProvjeriTabelu()
        {
            if (dgvStudenti.RowCount <= 0)
            {
                lblWarning.Text = "Unutar tabele nema studenata " + cmbSpolovi.SelectedItem.ToString().Trim('i')
                    + "og spola u razmaku od -> " + dateOd.Value.ToShortDateString() + " | " + dateDo.Value.ToShortDateString();
            }
            else
                lblWarning.Text = string.Empty;
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void dateDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void dateOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajTabelu();
        }
        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == dgvStudenti.ColumnCount - 1) 
            {
                var IdCell = dgvStudenti.Rows[e.RowIndex].Cells["Id"];
                if(IdCell != null && IdCell.Value != null && int.TryParse(IdCell.Value.ToString(), out var id)) 
                {
                    var frm = new frmUvjerenjaIB220088(id);
                    frm.Show();
                }
            }
            else if(e.RowIndex >= 0) 
            {
                var IdCell = dgvStudenti.Rows[e.RowIndex].Cells["Id"];
                if (IdCell != null && IdCell.Value != null && int.TryParse(IdCell.Value.ToString(), out var id))
                {
                    var frm = new StudentInfoIB220088(id);
                    frm.Show();
                }
            }
        }

        private void frmPretragaIB220088_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            UcitajTabelu();
        }
    }
}
