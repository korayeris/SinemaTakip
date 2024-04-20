using SinemaSeansTakip.Tabs;

namespace SinemaTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            FilmTab filmTab = new FilmTab();
            filmTab.ShowDialog();
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            SalonTab salonTab = new SalonTab();
            salonTab.ShowDialog();
        }

        private void btnSeans_Click(object sender, EventArgs e)
        {
            SeansTab seansTab = new SeansTab();
            seansTab.ShowDialog();
        }
    }
}
