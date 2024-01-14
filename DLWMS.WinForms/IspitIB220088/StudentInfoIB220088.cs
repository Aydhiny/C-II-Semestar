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
    public partial class StudentInfoIB220088 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private int id;

        public StudentInfoIB220088(int id)
        {
            this.id = id;
            InitializeComponent();
            var podaci = db.Studenti.Where(x => x.Id == id).ToList();
            foreach(var podatak in podaci) 
            {
                pcbSlika.Image = Helpers.ImageHelper.FromByteToImage(podatak.Slika);
                lblIme.Text = podatak.ToString();
                lblProsjek.Text = "Prosjek: " + db.StudentiPredmeti.Where(x => x.Id == id).Average(x => x.Ocjena).ToString("0.00");
            }
        }
    }
}
