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
    public partial class VisualizzaCommentiPost : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public VisualizzaCommentiPost(string email)
        {
            InitializeComponent();
            this.email = email;
            var codiciPost = from p in db.POSTs
                          select p.codicePost;
            foreach (var codicePost in codiciPost)
            {
                cmbbxPost.Items.Add(codicePost);
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
            if (cmbbxPost.Text == "")
            {
                MessageBox.Show("Devi scegliere un codice post!", "Errore codice post",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var commenti = from c in db.COMMENTIs
                           where c.codicePost == Int32.Parse(cmbbxPost.Text)
                           orderby c.data, c.time descending
                           select new { c.data, c.time, c.emailUtente, c.descrizione };
                dataGridView.DataSource = commenti;
            }
        }

        private void cmbbxPost_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
