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
    public partial class VisualizzaProdottiNonVenduti : Form
    {
        private Thread thread;
        private string email;

        public VisualizzaProdottiNonVenduti(string email)
        {
            InitializeComponent();
            this.email = email;
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var prodotti = from p in db.PRODOTTIs
                           where p.emailUtenteVendita == this.email && p.venduto == false
                           select new { p.nomeSezione, p.nomeCategoria, p.descrizione, p.prezzo };
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
