using Klassenbibliothek;

namespace Komponenten
{
    public partial class KundenErstellenForm : Form
    {
        public KundenErstellenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Kunde kunde = new Kunde();

            kunde.Name = TbNamenEingabe.Text;
            kunde.Adresse = tbAdresseKunden.Text;

            this.Close();

        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
