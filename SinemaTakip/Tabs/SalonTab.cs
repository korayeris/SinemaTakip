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
    public partial class SalonTab : Form
    {
        DbConnect DbConnect = new DbConnect();
        public SalonTab()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon();
            salon.Name = txtAd.Text;
            salon.Capacity = Convert.ToInt32(txtKapasite.Text);
            DbConnect.WriteTosalons(salon);
            
        }
    }
}
