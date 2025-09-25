namespace KleinGewerbeManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void kundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Komponenten.KundenErstellenForm kundenErstellenForm = new Komponenten.KundenErstellenForm();
            kundenErstellenForm.Show();
        }

        private void ausgabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Komponenten.Forms.AusgabeErstellenForm ausgabeErstellenForm = new Komponenten.Forms.AusgabeErstellenForm();
            ausgabeErstellenForm.Show();
        }

        private void ausgabenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Komponenten.Forms.MeineForm ausgaben‹bersichtForm = new Komponenten.Forms.MeineForm();
            ausgaben‹bersichtForm.Show();
        }
    }
}
