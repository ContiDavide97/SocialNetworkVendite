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
    public partial class VisualizzaPost : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public VisualizzaPost(string email)
        {
            InitializeComponent();
            this.email = email;
            var sezioni = from s in db.SEZIONIs
                             select s.nome;
            foreach (var sezione in sezioni)
            {
                cmbbxSezione.Items.Add(sezione);
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

        private void cmbbxSezione_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (cmbbxSezione.Text == "")
            {
                MessageBox.Show("Devi scegliere una sezione!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var post = from p in db.POSTs
                               where p.nomeSezione == cmbbxSezione.Text
                               orderby p.data, p.time descending
                               select new { p.codicePost, p.data, p.time, p.emailUtente, p.titolo, p.descrizione };
                dataGridView.DataSource = post;
            }
        }
    }
}
