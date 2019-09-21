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
    public partial class VisualizzaMessaggi : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public VisualizzaMessaggi(string email)
        {
            InitializeComponent();
            this.email = email;
            var usersEmail = from u in db.UTENTIs
                             where u.email != this.email
                             select u.email;
            foreach (var usererEmail in usersEmail)
            {
                cmbbxEmail.Items.Add(usererEmail);
            };
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

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (cmbbxEmail.Text == "")
            {
                MessageBox.Show("Devi scegliere l'utente!", "Errore utente",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var messages = from m in db.MESSAGGIs
                            where (m.emailMittente == this.email && m.emailDestinatario == cmbbxEmail.Text)
                            || (m.emailMittente == cmbbxEmail.Text && m.emailDestinatario == this.email)
                            orderby m.data, m.time
                            select new { m.data, m.time, m.emailMittente, m.emailDestinatario, m.descrizione };
                dataGridView.DataSource = messages;
            }
        }
        private void cmbbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
