using System;
using System.Collections.Generic;
using Scala.ClassLibrary.Core;

namespace Scala.ClassLibrary.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected static List<Persoon> personen;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Persoon student = new Persoon("Janssens", "Wim", new DateTime(1995, 12, 24), true);
                Persoon docent = new Persoon("Willems", "Jan", new DateTime(1985, 5, 1), true);
                personen = new List<Persoon>();
                personen.Add(student);
                personen.Add(docent);

                lstPersonen.DataSource = personen;
                lstPersonen.DataBind();
            }

        }

        protected void lstPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonen.SelectedIndex == -1)
                return;
            Persoon persoon = personen[lstPersonen.SelectedIndex];
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