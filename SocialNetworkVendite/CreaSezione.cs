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
    public partial class CreaSezione : Form
    {
        private Thread thread;
        private string email;
        private string imageLocation = "";

        public CreaSezione(string email)
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

        private void btnCrea_Click(object sender, EventArgs e)
        {

            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var sezione = from s in db.SEZIONIs
                          where s.nome == txtNomeSezione.Text
                          select s;
            if (sezione.Count() != 0) {
                MessageBox.Show("Questo nome di sezione è già utilizzato!", "Errore sezione",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtNomeSezione.Text == "") {
                MessageBox.Show("La sezione deve avere un nome!", "Errore sezione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtDescrizione.Text == "") {
                MessageBox.Show("Devi scegliere una descrizione!", "Errore descrizione",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                SEZIONI newSection = new SEZIONI
                {
                    nome = txtNomeSezione.Text,
                    descrizione = txtDescrizione.Text,
                    dataCreazione = DateTime.Now,
                    emailUtente = this.email
                };
                if (!imageLocation.Equals(""))
                {
                    byte[] bytesImage = null;
                    FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    bytesImage = brs.ReadBytes((int)Stream.Length);
                    newSection.immagine = bytesImage;
                }
                db.SEZIONIs.InsertOnSubmit(newSection);
                try
                {
                    db.SubmitChanges();
                    txtNomeSezione.Text = "";
                    txtDescrizione.Text = "";
                    imageLocation = "";
                    pictureBox.ImageLocation = "";
                    MessageBox.Show("Sezione creata con successo!", "Successo creazione sezione",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con la crezione della sessione!", "Errore creazione sessione",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
