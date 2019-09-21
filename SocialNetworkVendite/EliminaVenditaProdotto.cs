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
    public partial class EliminaVenditaProdotto : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;

        public EliminaVenditaProdotto(string email)
        {
            InitializeComponent();
            this.email = email;
            this.updateProducts();
        }

        private void updateProducts()
        {
            cmbbxCodiceProdotto.Text = "";
            cmbbxCodiceProdotto.Items.Clear();
            var prodotti = from p in db.PRODOTTIs
                           where p.emailUtenteVendita == this.email && p.venduto == null
                           select p.codiceProdotto;
            foreach (var prodotto in prodotti)
            {
                cmbbxCodiceProdotto.Items.Add(prodotto);
            };
        }

        private void cmbbxCodiceProdotto_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
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

        private void btnEliminaVendita_Click(object sender, EventArgs e)
        {
            if (cmbbxCodiceProdotto.Text == "")
            {
                MessageBox.Show("Devi scegliere un codice prodotto!", "Errore codice prodotto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                var prodotto = from p in db.PRODOTTIs
                               where p.codiceProdotto == Int32.Parse(cmbbxCodiceProdotto.Text)
                               select p;
                foreach (var prod in prodotto)
                {
                    prod.venduto = false;
                };
                try
                {
                    db.SubmitChanges();
                    this.updateProducts();
                    MessageBox.Show("Prodotto cancellato con successo!", "Successo cancellazione vendita prodotto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    MessageBox.Show("C'è stato qualche errore con la cancellazione del prodotto!", "Errore cancellazione vendita prodotto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
