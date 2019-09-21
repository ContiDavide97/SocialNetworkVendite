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
    public partial class CompraProdottoVendita : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public CompraProdottoVendita(string email)
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

        private void cmbbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxCodiceProdotto_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxSezione_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbbxCategoria.Items.Clear();
            cmbbxCategoria.Enabled = true;
            var categorie = from a in db.ASSOCIAZIONIs
                            where a.nomeSezione == cmbbxSezione.Text
                            select a.nomeCategoria;
            foreach (var categoria in categorie)
            {
                cmbbxCategoria.Items.Add(categoria);
            };
        }

        private void cmbbxCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbbxCodiceProdotto.Items.Clear();
            cmbbxCodiceProdotto.Enabled = true;
            var prodotti = from p in db.PRODOTTIs
                           where p.nomeSezione == cmbbxSezione.Text && p.nomeCategoria == cmbbxCategoria.Text && p.venduto == null
                                && p.emailUtenteVendita != this.email
                           select p.codiceProdotto;
            foreach (var prodotto in prodotti)
            {
                cmbbxCodiceProdotto.Items.Add(prodotto);
            };
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (cmbbxSezione.Text == "")
            {
                MessageBox.Show("Devi scegliere una sezione!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbbxCategoria.Text == "")
            {
                MessageBox.Show("Devi scegliere una categoria!", "Errore categoria",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbbxCodiceProdotto.Text == "")
            {
                MessageBox.Show("Devi scegliere un codice prodotto!", "Errore codice prodotto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var prodotto = from p in db.PRODOTTIs
                               where p.codiceProdotto == Int32.Parse(cmbbxCodiceProdotto.Text)
                               select p;
                foreach (var prod in prodotto)
                {
                    prod.emailUtenteAcquisto = this.email;
                    prod.dataAcquisto = DateTime.Now;
                    prod.venduto = true;
                };
                try
                {
                    db.SubmitChanges();
                    cmbbxSezione.Text = "";
                    cmbbxCategoria.Text = "";
                    cmbbxCodiceProdotto.Text = "";
                    cmbbxCategoria.Items.Clear();
                    cmbbxCodiceProdotto.Items.Clear();
                    cmbbxCategoria.Enabled = false;
                    cmbbxCodiceProdotto.Enabled = false;
                    MessageBox.Show("Prodotto acquistato con successo!", "Successo acquisto prodotto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con l'acquisto del prodotto!", "Errore acquisto prodotto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
