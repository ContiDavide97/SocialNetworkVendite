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
    public partial class CreaCategoria : Form
    {
        private Thread thread;
        private string email;

        public CreaCategoria(string email)
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

        private void btnCrea_Click(object sender, EventArgs e)
        {
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var categoria = from c in db.CATEGORIEs
                          where c.nome == txtNomeCategoria.Text
                          select c;
            if (categoria.Count() != 0)
            {
                MessageBox.Show("Questo nome di categoria è già utilizzato!", "Errore sezione",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNomeCategoria.Text == "")
            {
                MessageBox.Show("La categoria deve avere un nome!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDescrizione.Text == "")
            {
                MessageBox.Show("Devi scegliere una descrizione!", "Errore descrizione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CATEGORIE newCategory = new CATEGORIE
                {
                    nome = txtNomeCategoria.Text,
                    descrizione = txtDescrizione.Text,
                    emailUtente = this.email
                };
                db.CATEGORIEs.InsertOnSubmit(newCategory);
                try
                {
                    db.SubmitChanges();
                    txtNomeCategoria.Text = "";
                    txtDescrizione.Text = "";
                    MessageBox.Show("Categoria creata con successo!", "Successo creazione categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con la crezione della categoria!", "Errore creazione categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
