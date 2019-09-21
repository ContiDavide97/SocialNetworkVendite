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
    public partial class CreaPost : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public CreaPost(string email)
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

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (cmbbxSezione.Text == "") {
                MessageBox.Show("Devi scegliere una sezione!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtTitolo.Text == "") {
                MessageBox.Show("Devi scegliere un titolo!", "Errore titolo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtMessaggio.Text == "") {
                MessageBox.Show("Non puoi lasciare la descrizione vuota!", "Errore descrizione",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                POST newPost = new POST
                {
                    data = DateTime.Now,
                    time = DateTime.Now.TimeOfDay,
                    titolo = txtTitolo.Text,
                    descrizione = txtMessaggio.Text,
                    emailUtente = this.email,
                    nomeSezione = cmbbxSezione.Text
                };
                db.POSTs.InsertOnSubmit(newPost);
                try
                {
                    db.SubmitChanges();
                    cmbbxSezione.Text = "";
                    txtTitolo.Text = "";
                    txtMessaggio.Text = "";
                    MessageBox.Show("Post creato con successo!", "Successo invio messaggio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con la creazione del post!", "Errore creazione post",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
