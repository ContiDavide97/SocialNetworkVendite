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
    public partial class VisualizzaProdottoVendita : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public VisualizzaProdottoVendita(string email)
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

        private void cmbbxSezione_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbbxCategoria.Text = "";
            cmbbxCategoria.Items.Clear();
            cmbbxCategoria.Enabled = true;
            var categorie = from a in db.ASSOCIAZIONIs
                            where a.nomeSezione == cmbbxSezione.Text
                            select a.nomeCategoria;
            foreach (var categoria in categorie)
            {
                cmbbxCategoria.Items.Add(categoria);
            };
            cmbbxCategoria.Items.Add("Tutte");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (cmbbxSezione.Text == "") {
                MessageBox.Show("Devi scegliere una sezione!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbbxCategoria.Text == "")
            {
                MessageBox.Show("Devi scegliere una categoria!", "Errore categoria",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                IQueryable prodotti;
                if (cmbbxCategoria.Text != "Tutte") {
                    prodotti = from p in db.PRODOTTIs
                               where p.nomeSezione == cmbbxSezione.Text && p.nomeCategoria == cmbbxCategoria.Text && p.venduto == null
                               select new { p.codiceProdotto, p.dataVendita, p.emailUtenteVendita, p.descrizione, p.prezzo };
                } else {
                    prodotti = from p in db.PRODOTTIs
                               where p.nomeSezione == cmbbxSezione.Text && p.venduto == null
                               select new { p.nomeCategoria, p.codiceProdotto, p.dataVendita, p.emailUtenteVendita, p.descrizione, p.prezzo };
                }
                dataGridView.DataSource = prodotti;
            }
        }
    }
}
