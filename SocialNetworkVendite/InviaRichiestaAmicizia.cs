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
    public partial class InviaRichiestaAmicizia : Form
    {
        private Thread thread;
        private string email;

        public InviaRichiestaAmicizia(string email)
        {
            InitializeComponent();
            this.email = email;
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

        private void btnInvia_Click(object sender, EventArgs e)
        {
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var friends = from a in db.AMICIZIEs
                           where (a.emailUtente1 == this.email && a.emailUtente2 == txtEmailUtente.Text) 
                                || (a.emailUtente1 == txtEmailUtente.Text && a.emailUtente2 == this.email)
                           select a;
            var r1 = from r in db.RICHIESTE_AMICIZIEs
                     where r.emailMittente == this.email && r.emailDestinatario == txtEmailUtente.Text && r.dataRisposta == null
                     select r;
            var r2 = from r in db.RICHIESTE_AMICIZIEs
                     where r.emailMittente == txtEmailUtente.Text && r.emailDestinatario == this.email && r.dataRisposta == null
                     select r;
            var searchUser = from u in db.UTENTIs
                             where u.email == txtEmailUtente.Text
                             select u;

            if (txtEmailUtente.Text == "") {
                MessageBox.Show("Devi inserire la email di un utente!", "Errore email utente",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (friends.Count() != 0) {
                MessageBox.Show("Sei già amico con questo utente!", "Errore richiesta amicizia",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(r1.Count() != 0) {
                MessageBox.Show("Hai già inviato la richiesta di amicizia a questo utente!", "Errore richiesta amicizia",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(r2.Count() != 0) {
                MessageBox.Show(txtEmailUtente.Text + " ti ha già inviato la richiesta di amicizia!", "Errore richiesta amicizia",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (searchUser.Count() == 0) {
                MessageBox.Show(txtEmailUtente.Text + " non trovata!", "Errore ricerca email",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                RICHIESTE_AMICIZIE newFriendRequest = new RICHIESTE_AMICIZIE
                {
                    emailMittente = this.email,
                    emailDestinatario = txtEmailUtente.Text,
                    dataRichiesta = DateTime.Now,
                    timeRichiesta = DateTime.Now.TimeOfDay
                };
                db.RICHIESTE_AMICIZIEs.InsertOnSubmit(newFriendRequest);
                try
                {
                    db.SubmitChanges();
                    txtEmailUtente.Text = "";
                    MessageBox.Show("Richiesta amicizia inviata con successo!", "Successo invio richiesta amicizia",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con l'invio della richiesta di amicizia!", 
                        "Errore invio richiesta amicizia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
