using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SocialNetworkVendite
{
    public partial class VisualizzaProdottiComprati : Form
    {
        private Thread thread;
        private string email;

        public VisualizzaProdottiComprati(string email)
        {
            InitializeComponent();
            this.email = email;
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var prodotti = from p in db.PRODOTTIs
                           where p.emailUtenteAcquisto == this.email
                           select new { p.emailUtenteVendita, p.nomeSezione, p.nomeCategoria, p.dataAcquisto, p.descrizione, p.prezzo };
            dataGridView.DataSource = prodotti;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openHome);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openHome()
        {
            Application.Run(new Home(this.email));
        }
    }
}
