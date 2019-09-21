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
    public partial class VisualizzaProdottiAttualmenteInVendita : Form
    {
        private Thread thread;
        private string email;

        public VisualizzaProdottiAttualmenteInVendita(string email)
        {
            InitializeComponent();
            this.email = email;
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var prodotti = from p in db.PRODOTTIs
                           where p.emailUtenteVendita == this.email && p.venduto == null
                           select new { p.nomeSezione, p.nomeCategoria, p.dataVendita, p.descrizione, p.prezzo };
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
