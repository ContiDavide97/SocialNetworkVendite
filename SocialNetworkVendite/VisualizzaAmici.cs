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
    public partial class VisualizzaAmici : Form
    {
        private Thread thread;
        private string email;

        public VisualizzaAmici(string email)
        {
            InitializeComponent();
            this.email = email;
            SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
            var friends1 = from a in db.AMICIZIEs join u in db.UTENTIs on a.emailUtente2 equals u.email
                       where a.emailUtente1 == this.email && a.dataFine == null
                       select new { u.nome, u.cognome, u.email };
            var friends2 = from a in db.AMICIZIEs
                           join u in db.UTENTIs on a.emailUtente1 equals u.email
                           where a.emailUtente2 == this.email && a.dataFine == null
                           select new { u.nome, u.cognome, u.email };

            foreach (var userInfo in friends1)
            {
                listBoxNome.Items.Add(userInfo.nome);
                listBoxCognome.Items.Add(userInfo.cognome);
                listBoxEmail.Items.Add(userInfo.email);
            };
            foreach (var userInfo in friends2)
            {
                listBoxNome.Items.Add(userInfo.nome);
                listBoxCognome.Items.Add(userInfo.cognome);
                listBoxEmail.Items.Add(userInfo.email);
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
    }
}
