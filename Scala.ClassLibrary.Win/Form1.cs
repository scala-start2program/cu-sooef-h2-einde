using Scala.ClassLibrary.Core;

namespace Scala.ClassLibrary.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Persoon student = new Persoon("Janssens", "Wim", new DateTime(1995, 12, 24), true);
            Persoon docent = new Persoon("Willems", "Jan", new DateTime(1985, 5, 1), true);

            lstPersonen.Items.Add(student);
            lstPersonen.Items.Add(docent);
        }
        private void LstPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persoon persoon = (Persoon)lstPersonen.SelectedItem;
            lblNaam.Text = persoon.Naam;
            lblVoornaam.Text = persoon.Voornaam;
            lblGeboortedatum.Text = persoon.Geboortedatum.ToString("ddd dd/MM/yyyy");
            if (persoon.IsMan)
                lblGeslacht.Text = "Man";
            else
                lblGeslacht.Text = "Vrouw";
            lblLeeftijd.Text = persoon.GetLeeftijd();
        }


    }
}