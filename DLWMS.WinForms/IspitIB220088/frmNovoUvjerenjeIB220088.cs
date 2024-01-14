using DLWMS.Data;
using DLWMS.Data.IspitIB220088;
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
    public partial class frmNovoUvjerenjeIB220088 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private int id;

        public frmNovoUvjerenjeIB220088(int id)
        {
            this.id = id;
            InitializeComponent();
            ucitajVrste();
        }

        private void ucitajVrste()
        {
            List<string> list = new List<string>();
            list.Add("Uvjerenje o statusu studenta");
            list.Add("Uvjerenje o položenim ispitima");
            list.Add("Uvjerenje o prosjeku studenta");
            cmbVrsta.DataSource = list;
        }

        private void pcbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            var od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                pcbUplatnica.Image = Image.FromFile(od.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(jeValidno()) 
            {
                var novoUvjerenje = new StudentiUvjerenjaIB220088() 
                {
                    StudentId = id,
                    Datum = DateTime.Now,
                    Svrha = txtSvrha.Text,
                    Vrsta = cmbVrsta.SelectedItem.ToString(),
                    Printano = false,
                    Uplatnica = Helpers.ImageHelper.FromImageToByte(pcbUplatnica.Image)
                };
                db.StudentiUvjerenjaIB220088.Add(novoUvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ValidirajKontrolu(pcbUplatnica, err, Helpers.Kljucevi.ObaveznaVrijednost) 
                && Helpers.Validator.ValidirajKontrolu(txtSvrha, err, Helpers.Kljucevi.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(cmbVrsta, err, Helpers.Kljucevi.ObaveznaVrijednost);
        }
    }
}
