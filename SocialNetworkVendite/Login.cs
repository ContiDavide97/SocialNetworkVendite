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
    public partial class Login : Form
    {
        private Thread thread;
        private string email = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var query = from u in db.UTENTIs
                        where u.email == txtEmail.Text && u.password == txtPassword.Text
                        select u.email;
            Boolean loginOk = query.Count() == 1 ? true : false;
            if (loginOk)
            {
                this.email = query.First();
                openForm("home");
            } else {
                MessageBox.Show("Email o password errati!", "Errore login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openForm(string formName) {
            if(formName.Equals("register") || formName.Equals("home")) {
                this.Close();
                if (formName.Equals("register"))
                {
                    thread = new Thread(openRegisterForm);
                }
                else if (formName.Equals("home"))
                {
                    thread = new Thread(openHomeForm);
                }
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm("register");
        }

        private void openRegisterForm()
        {
            Application.Run(new Register());
        }

        private void openHomeForm()
        {
            Application.Run(new Home(email));
        }
    }
}
