using SinemaTakip.DataAccess;
using SinemaTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSeansTakip.Tabs
{
    public partial class SeansTab : Form
    {
        DbConnect DbConnect = new DbConnect();
        public SeansTab()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Seans seans = new Seans();
            seans.FilmId = Convert.ToInt32(txtFilmId.Text);
            seans.SalonId = Convert.ToInt32(txtSalonId.Text);
            seans.Duration = Convert.ToInt32(txtSure.Text);
            seans.StartTime = txtBaslangic.Text;
            seans.Price = Convert.ToInt32(txtUcret.Text);
            DbConnect.WriteTosessions(seans);
        }
    }
}
