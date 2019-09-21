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
using System.IO;

namespace SocialNetworkVendite
{
    public partial class VendiProdotto : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;
        private string imageLocation = "";

        public VendiProdotto(string email)
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
            var categorie = from a in db.ASSOCIAZIONIs
                            where a.nomeSezione == cmbbxSezione.Text
                            select a.nomeCategoria;
            foreach (var categoria in categorie)
            {
                cmbbxCategoria.Items.Add(categoria);
            };
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Scelta immagine";
            dialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imageLocation;
            }
        }

        private void btnVendi_Click(object sender, EventArgs e)
        {
            int productPrice;
            if (cmbbxSezione.Text == "")
            {
                MessageBox.Show("Devi scegliere una sezione!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbbxCategoria.Text == "") {
                MessageBox.Show("Devi scegliere una categoria!", "Errore categoria",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPrezzo.Text == "") {
                MessageBox.Show("Devi inserire un prezzo per il prodotto!", "Errore prezzo prodotto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!Int32.TryParse(txtPrezzo.Text, out productPrice)) {
                MessageBox.Show("Devi inserire un prezzo valido composto da soli numeri!", "Errore prezzo prodotto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                PRODOTTI newProduct = new PRODOTTI
                {
                    dataVendita = DateTime.Now,
                    emailUtenteVendita = this.email,
                    nomeSezione = cmbbxSezione.Text,
                    nomeCategoria = cmbbxCategoria.Text,
                    prezzo = productPrice
                };
                if (txtDescrizione.Text != "") {
                    newProduct.descrizione = txtDescrizione.Text;
                }
                if (!imageLocation.Equals(""))
                {
                    byte[] bytesImage = null;
                    FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    bytesImage = brs.ReadBytes((int)Stream.Length);
                    newProduct.immagine = bytesImage;
                }
                db.PRODOTTIs.InsertOnSubmit(newProduct);
                try
                {
                    db.SubmitChanges();
                    cmbbxSezione.Text = "";
                    cmbbxCategoria.Text = "";
                    txtPrezzo.Text = "";
                    txtDescrizione.Text = "";
                    cmbbxCategoria.Enabled = false;
                    imageLocation = "";
                    pictureBox.ImageLocation = "";
                    cmbbxCategoria.Items.Clear();
                    MessageBox.Show("Prodotto messo in vendita con successo!", "Successo vendita prodotto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con la messa in vendita del prodotto!", "Errore vendita prodotto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
    }
}
