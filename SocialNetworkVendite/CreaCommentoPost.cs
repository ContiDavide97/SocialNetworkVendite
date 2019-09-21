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
    public partial class InviaCommentoPost : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public InviaCommentoPost(string email)
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

        private void cmbbxPost_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (cmbbxPost.Text == "")
            {
                MessageBox.Show("Devi scegliere un codice post!", "Errore codice post",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMessaggio.Text == "")
            {
                MessageBox.Show("Non puoi inviare un messaggio vuoto!", "Errore messaggio",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                COMMENTI newComment = new COMMENTI
                {
                    codicePost = Int32.Parse(cmbbxPost.Text),
                    data = DateTime.Now,
                    time = DateTime.Now.TimeOfDay,
                    descrizione = txtMessaggio.Text,
                    emailUtente = this.email
                };
                db.COMMENTIs.InsertOnSubmit(newComment);
                try
                {
                    db.SubmitChanges();
                    cmbbxPost.Text = "";
                    txtMessaggio.Text = "";
                    MessageBox.Show("Commento inviato con successo!", "Successo invio commento",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con l'invio del commento!", "Errore invio commento",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
