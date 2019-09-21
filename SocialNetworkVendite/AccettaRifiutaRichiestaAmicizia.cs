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
    public partial class AccettaRifiutaRichiestaAmicizia : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public AccettaRifiutaRichiestaAmicizia(string email)
        {
            InitializeComponent();
            this.email = email;
            this.updateUsers();
        }

        private void updateUsers()
        {
            this.cmbbxEmailUtente.Text = "";
            this.cmbbxEmailUtente.Items.Clear();
            var users = from r in db.RICHIESTE_AMICIZIEs
                        where r.emailDestinatario == this.email && r.dataRisposta == null
                        select r.emailMittente;
            foreach (var user in users)
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

        private void btnAccetta_Click(object sender, EventArgs e)
        {
            this.resultFriendRequest(true);
        }

        private void btnRifiusta_Click(object sender, EventArgs e)
        {
            this.resultFriendRequest(false);
        }

        private void resultFriendRequest(Boolean accept)
        {
            if (cmbbxEmailUtente.Text == "")
            {
                MessageBox.Show("Devi scegliere una email di un utente!", "Errore email utente",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                var user = from r in db.RICHIESTE_AMICIZIEs
                           where r.emailMittente == cmbbxEmailUtente.Text && r.emailDestinatario == this.email && r.dataRisposta == null
                           select r;
                foreach (var u in user)
                {
                    u.accettata = accept;
                    u.dataRisposta = DateTime.Now;
                    u.timeRisposta = DateTime.Now.TimeOfDay;
                };
                if (accept)
                {
                    AMICIZIE newFriend = new AMICIZIE
                    {
                        dataInizio = DateTime.Now,
                        timeInizio = DateTime.Now.TimeOfDay,
                        emailUtente1 = cmbbxEmailUtente.Text,
                        emailUtente2 = this.email
                    };
                    db.AMICIZIEs.InsertOnSubmit(newFriend);
                }
                try
                {
                    db.SubmitChanges();
                    this.updateUsers();
                    if (accept)
                    {
                        MessageBox.Show("Utente aggiunto con successo!", "Successo aggiunta utente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Utente rifiutato con successo!", "Successo rifiuto utente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore!", "Errore",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
