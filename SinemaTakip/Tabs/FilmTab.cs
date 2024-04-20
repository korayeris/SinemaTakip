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
    public partial class FilmTab : Form
    {
        DbConnect DbConnect = new DbConnect();
        public FilmTab()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Title = txtAd.Text;
            film.Description = txtAciklama.Text;
            film.Director = txtYonetmen.Text;
            film.Duration = Convert.ToInt32(txtSure.Text);
            DateTime release;
            if(DateTime.TryParse(dateTimeRelease.Text, out release))
            {
                film.ReleaseDate = release;
            }
            else
            {
                film.ReleaseDate = DateTime.Now;
            }
            film.CreatedAt = DateTime.Now;

            DbConnect.WriteTofilms(film);

        }
    }
}
