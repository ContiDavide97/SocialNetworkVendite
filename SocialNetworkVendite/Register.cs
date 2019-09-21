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
    public partial class Register : Form
    {
        private string imageLocation = "";
        private Thread threadLogin;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cmbbxSesso.Items.Add("Maschio");
            cmbbxSesso.Items.Add("Femmina");
            
            cmbbxAmministratore.Items.Add("True");
            cmbbxAmministratore.Items.Add("False");

            for (int i=1; i <= 31; i++ ) {
                cmbbxDataGiorno.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                cmbbxDataMese.Items.Add(i.ToString());
            }

            for (int i = 1900; i <= 2018; i++)
            {
                cmbbxDataAnno.Items.Add(i.ToString());
            }

            for (int i = 0; i <= 15000; i++)
            {
                cmbbxNumeroCivico.Items.Add(i.ToString());
            }

            

        }

        private void cmbbxAmministratore_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxNumeroCivico_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxDataGiorno_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxDataMese_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxDataAnno_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbbxSesso_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Scelta immagine";
            dialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            if (dialog.ShowDialog() == DialogResult.OK) {
                imageLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imageLocation;
            }
        }

        private void btnTornaLogin_Click(object sender, EventArgs e)
        {
            returnLogin();
        }

        private void returnLogin()
        {
            this.Close();
            threadLogin = new Thread(openLoginForm);
            threadLogin.SetApartmentState(ApartmentState.STA);
            threadLogin.Start();
        }

        private void openLoginForm()
        {
            Application.Run(new Login());
        }

        private void btnIscriviti_Click(object sender, EventArgs e)
        {
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            long telephoneNumber;
            var query = from u in db.UTENTIs
                        where u.email == txtEmail.Text
                        select u.email;
            Boolean emailOk = query.Count() == 0 ? true: false;
            if (!emailOk) {
                MessageBox.Show("La seguente email: " + txtEmail + "è già presente!", "Email esistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtNumeroTelefono.Text.Length != 10) {
                MessageBox.Show("Il numero di telefono deve essere composto da 10 numeri", "Numero di telefono errato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(!long.TryParse(txtNumeroTelefono.Text, out telephoneNumber)) {
                    MessageBox.Show("Il numero di telefono deve essere composto da soli numeri!", "Numero di telefono errato",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtEmail.Text == "" || txtPassword.Text == "" || txtNome.Text == "" || txtCognome.Text == ""
                || txtLuogoNascita.Text == "" || txtVia.Text == "" || txtCitta.Text == "" || cmbbxSesso.Text == ""
                || cmbbxDataGiorno.Text == "" || cmbbxDataMese.Text == "" || cmbbxDataAnno.Text == ""
                || cmbbxNumeroCivico.Text == "" || cmbbxAmministratore.Text == "")
            {
                MessageBox.Show("Ci sono uno o più campi non compilati!", "Campo/i non compilato/i",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if ((cmbbxDataMese.Text == "4" || cmbbxDataMese.Text == "6" || cmbbxDataMese.Text == "9" || cmbbxDataMese.Text == "11") && cmbbxDataGiorno.Text == "31") {
                MessageBox.Show("Il giorno di nascita non può essere 31!", "Data Errata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (cmbbxDataMese.Text == "2" && (cmbbxDataGiorno.Text == "29" || cmbbxDataGiorno.Text == "30" || cmbbxDataGiorno.Text == "31")) {
                MessageBox.Show("Il giorno di nascita non può essere maggiore di 28!", "Data Errata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                UTENTI newUser;
                newUser = new UTENTI
                {
                    email = txtEmail.Text,
                    password = txtPassword.Text,
                    nome = txtNome.Text,
                    cognome = txtCognome.Text,
                    sesso = cmbbxSesso.Text.Equals("Maschio") ? "M" : "F",
                    dataNascita = new DateTime(Int32.Parse(cmbbxDataAnno.Text), Int32.Parse(cmbbxDataMese.Text), Int32.Parse(cmbbxDataGiorno.Text)),
                    luogoNascita = txtLuogoNascita.Text,
                    viaResidenza = txtVia.Text,
                    numeroCivicoResidenza = Int16.Parse(cmbbxNumeroCivico.Text),
                    cittaResidenza = txtCitta.Text,
                    numeroTelefono = txtNumeroTelefono.Text,
                    amministratore = cmbbxAmministratore.Text.Equals("True") ? true : false
                };
                if (!imageLocation.Equals("")) {
                    byte[] bytesImage = null;
                    FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    bytesImage = brs.ReadBytes((int)Stream.Length);
                    newUser.immagine = bytesImage;
                }
                db.UTENTIs.InsertOnSubmit(newUser);
                try
                {
                    db.SubmitChanges();
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtNome.Text = "";
                    txtCognome.Text = "";
                    cmbbxSesso.Text = "";
                    cmbbxDataGiorno.Text = "";
                    cmbbxDataMese.Text = "";
                    cmbbxDataAnno.Text = "";
                    txtLuogoNascita.Text = "";
                    txtVia.Text = "";
                    cmbbxNumeroCivico.Text = "";
                    txtCitta.Text = "";
                    txtNumeroTelefono.Text = "";
                    cmbbxAmministratore.Text = "";
                    imageLocation = "";
                    pictureBox.ImageLocation = "";
                    MessageBox.Show("Iscrizione avvenuta con successo!", "Successo iscrizione",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    returnLogin();
                }  catch (Exception e1) {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con l'iscrizione!", "Errore iscrizione",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
