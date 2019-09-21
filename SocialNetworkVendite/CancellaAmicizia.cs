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
    public partial class CancellaAmicizia : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public CancellaAmicizia(string email)
        {
            InitializeComponent();
            this.email = email;
            this.updateUsers();
        }

        private void updateUsers()
        {
            this.cmbbxEmailUtente.Text = "";
            this.cmbbxEmailUtente.Items.Clear();
            var users1 = from a in db.AMICIZIEs
                         where a.emailUtente1 == this.email && a.dataFine == null
                         select a.emailUtente2;
            var users2 = from a in db.AMICIZIEs
                         where a.emailUtente2 == this.email && a.dataFine == null
                         select a.emailUtente1;
            foreach (var user in users1)
            {
                cmbbxEmailUtente.Items.Add(user);
            };
            foreach (var user in users2)
            {
                cmbbxEmailUtente.Items.Add(user);
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

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if (cmbbxEmailUtente.Text == "") {
                MessageBox.Show("Devi scegliere una email di un utente!", "Errore email utente",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                var friend1 = from a in db.AMICIZIEs
                           where a.emailUtente1 == this.email && a.emailUtente2 == cmbbxEmailUtente.Text && a.dataFine == null 
                           select a;
                if ( friend1.Count() == 0) {
                    var friend2 = from a in db.AMICIZIEs
                                  where a.emailUtente1 == cmbbxEmailUtente.Text && a.emailUtente2 == this.email && a.dataFine == null
                                  select a;
                    this.updateFriend(friend2);
                } else {
                    this.updateFriend(friend1);
                }
            }
        }

        private void updateFriend(IQueryable<AMICIZIE> friend)
        {
            foreach (var f in friend)
            {
                f.dataFine = DateTime.Now;
                f.timeFine = DateTime.Now.TimeOfDay;
            };
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Cancellazione amicizia avvenuta con successo!", "Successo cancellazione amicizia",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.updateUsers();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
                MessageBox.Show("C'è stato qualche errore con la cancellazione dell'amicizia!", "Errore cancelazione amicizia",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
