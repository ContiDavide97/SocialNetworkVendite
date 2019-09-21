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
    public partial class AssociaCategoriaSezione : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public AssociaCategoriaSezione(string email)
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
            cmbbxCategoria.Items.Clear();
            cmbbxCategoria.Enabled = true;
            var categories = from c in db.CATEGORIEs
                        where !(from a in db.ASSOCIAZIONIs where a.nomeSezione == cmbbxSezione.Text select a.nomeCategoria)
                            .Contains(c.nome)
                        select c.nome;

             foreach (var category in categories)
             {
                 cmbbxCategoria.Items.Add(category);
             };
             
             cmbbxCategoria.Enabled = true;
            
        }

        private void btnAssocia_Click(object sender, EventArgs e)
        {
            if (cmbbxSezione.Text == "") {
                MessageBox.Show("Devi scegliere una sezione!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbbxCategoria.Text == "") {
                MessageBox.Show("Devi scegliere una categoria!", "Errore categoria",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                ASSOCIAZIONI newAssociation = new ASSOCIAZIONI
                {
                    nomeSezione = cmbbxSezione.Text,
                    nomeCategoria = cmbbxCategoria.Text
                };
                db.ASSOCIAZIONIs.InsertOnSubmit(newAssociation);
                try
                {
                    db.SubmitChanges();
                    cmbbxSezione.Text = "";
                    cmbbxCategoria.Text = "";
                    cmbbxCategoria.Items.Clear();
                    cmbbxCategoria.Enabled = false;
                    MessageBox.Show("Categoria aggiunta con successo alla sezione!", "Successo associazione categoria-sezione",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con l'associazione della categoria alla sessione!",
                        "Errore associazione categoria-sessione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
