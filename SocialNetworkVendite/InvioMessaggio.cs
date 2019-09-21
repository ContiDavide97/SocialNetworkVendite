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
    public partial class InvioMessaggio : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public InvioMessaggio(string email)
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

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (txtMessaggio.Text == "") {
                MessageBox.Show("Non puoi inviare un messaggio vuoto!", "Errore messaggio",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbbxEmail.Text == "") {
                MessageBox.Show("Devi scegliere il destinatario del messaggio!", "Errore email",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                MESSAGGI newMessage = new MESSAGGI
                {
                    data = DateTime.Now,
                    time = DateTime.Now.TimeOfDay,
                    descrizione = txtMessaggio.Text,
                    emailMittente = this.email,
                    emailDestinatario = cmbbxEmail.Text
                };
                db.MESSAGGIs.InsertOnSubmit(newMessage);
                try
                {
                    db.SubmitChanges();
                    cmbbxEmail.Text = "";
                    txtMessaggio.Text = "";
                    MessageBox.Show("Messaggio inviato con successo!", "Successo invio messaggio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con l'invio del messaggio!", "Errore invio messaggio",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void cmbbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
