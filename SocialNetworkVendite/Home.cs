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
    public partial class Home : Form
    {
        private SocialNetworkVenditeDbDataContext db = new SocialNetworkVenditeDbDataContext();
        private Thread thread;
        private string email;
        public Home(string email)
        {
            InitializeComponent();
            this.email = email;
            var query = from u in db.UTENTIs
                        where u.email == this.email
                        select new { u.email, u.nome, u.cognome, u.amministratore };
            foreach (var userInfo in query) {
                lblInfo.Text = userInfo.email + ", " + userInfo.cognome + " " + userInfo.nome;
                if (userInfo.amministratore)
                {
                    btnCreaSezione.Enabled = true;
                    btnCreaCategoria.Enabled = true;
                    btnAssociaCategoriaSezione.Enabled = true;
                }
            };
        }

       
        private void btnVisualizzaAmici_Click(object sender, EventArgs e)
        {
            openForm("visualizzaAmici");
        }

        private void openForm(string formName)
        {
            if (formName.Equals("visualizzaAmici") || formName.Equals("invioRichiestaAmicizia") || formName.Equals("invioMessaggio")
                || formName.Equals("visualizeMessage") || formName.Equals("visualizePost") || formName.Equals("createPost")
                || formName.Equals("visualizeCommentsPost") || formName.Equals("createCommentPost") 
                || formName.Equals("visualizeSaleProdouct") || formName.Equals("buySaleProdouct") || formName.Equals("sellProduct")
                || formName.Equals("deleteSellProduct") || formName.Equals("visualizeBuyProduct") 
                || formName.Equals("visualizeSellProduct") || formName.Equals("visualizeNotSellProduct") 
                || formName.Equals("visualizeCurrentlySellProduct") || formName.Equals("createSection") 
                || formName.Equals("createCategory") || formName.Equals("associateCategorySection") || formName.Equals("returnLogin")
                || formName.Equals("acceptDeclineFriendRequest") || formName.Equals("deleteFriend") 
                || formName.Equals("visualizeAllUsers"))
            {
                this.Close();
                if (formName.Equals("visualizzaAmici")) {
                    thread = new Thread(openViewfriends);
                } else if (formName.Equals("invioRichiestaAmicizia")) {
                    thread = new Thread(openSendRequestFriend);
                } else if (formName.Equals("invioMessaggio")) {
                    thread = new Thread(openSendMessage);
                } else if (formName.Equals("visualizeMessage")) {
                    thread = new Thread(openVisualizeMessage);
                } else if (formName.Equals("visualizePost")) {
                    thread = new Thread(openVisualizePost);
                } else if (formName.Equals("createPost")) {
                    thread = new Thread(openCreatePost);
                } else if (formName.Equals("visualizeCommentsPost")) {
                    thread = new Thread(openVisualizeCommentsPost);
                } else if (formName.Equals("createCommentPost")) {
                    thread = new Thread(openCreateCommentPost);
                } else if (formName.Equals("visualizeSaleProdouct")) {
                    thread = new Thread(openVisualizeSalePrdouct);
                } else if (formName.Equals("buySaleProdouct")) {
                    thread = new Thread(openBuySaleProdouct);
                } else if (formName.Equals("sellProduct")) {
                    thread = new Thread(openSellProdouct);
                } else if (formName.Equals("deleteSellProduct")) {
                    thread = new Thread(openDeleteSellProdouct);
                } else if (formName.Equals("visualizeBuyProduct")) {
                    thread = new Thread(openVisualizeBuyProdouct);
                } else if (formName.Equals("visualizeSellProduct")) {
                    thread = new Thread(openVisualizeSellProdouct);
                } else if (formName.Equals("visualizeNotSellProduct")) {
                    thread = new Thread(openVisualizeNotSellProdouct);
                } else if (formName.Equals("visualizeCurrentlySellProduct")) {
                    thread = new Thread(openVisualizeCurrentlySellProdouct);
                } else if (formName.Equals("createSection")) {
                    thread = new Thread(openCreateSection);
                } else if (formName.Equals("createCategory")) {
                    thread = new Thread(openCreateCategory);
                } else if (formName.Equals("associateCategorySection")) {
                    thread = new Thread(openAssociateCategorySection);
                } else if (formName.Equals("returnLogin")) {
                    thread = new Thread(openReturnLogin);
                } else if (formName.Equals("acceptDeclineFriendRequest")) {
                    thread = new Thread(openAcceptDeclineFriendRequest);
                } else if (formName.Equals("deleteFriend")) {
                    thread = new Thread(openDeleteFriend);
                } else if (formName.Equals("visualizeAllUsers")) {
                    thread = new Thread(openVisualizeAllUsers);
                }
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void openVisualizeAllUsers()
        {
            Application.Run(new VisualizzaTuttiUtenti(this.email));
        }

        private void openDeleteFriend()
        {
            Application.Run(new CancellaAmicizia(this.email));
        }

        private void openAcceptDeclineFriendRequest()
        {
            Application.Run(new AccettaRifiutaRichiestaAmicizia(this.email));
        }

        private void openReturnLogin()
        {
            Application.Run(new Login());
        }

        private void openAssociateCategorySection()
        {
            Application.Run(new AssociaCategoriaSezione(this.email));
        }

        private void openCreateCategory()
        {
            Application.Run(new CreaCategoria(this.email));
        }

        private void openCreateSection()
        {
            Application.Run(new CreaSezione(this.email));
        }

        private void openVisualizeCurrentlySellProdouct()
        {
            Application.Run(new VisualizzaProdottiAttualmenteInVendita(this.email));
        }

        private void openVisualizeNotSellProdouct()
        {
            Application.Run(new VisualizzaProdottiNonVenduti(this.email));
        }

        private void openVisualizeSellProdouct()
        {
            Application.Run(new VisualizzaProdottiVenduti(this.email));
        }

        private void openVisualizeBuyProdouct()
        {
            Application.Run(new VisualizzaProdottiComprati(this.email));
        }

        private void openDeleteSellProdouct()
        {
            Application.Run(new EliminaVenditaProdotto(this.email));
        }

        private void openSellProdouct()
        {
            Application.Run(new VendiProdotto(this.email));
        }

        private void openBuySaleProdouct()
        {
            Application.Run(new CompraProdottoVendita(this.email));
        }

        private void openVisualizeSalePrdouct()
        {
            Application.Run(new VisualizzaProdottoVendita(this.email));
        }

        private void openCreateCommentPost()
        {
            Application.Run(new InviaCommentoPost(this.email));
        }

        private void openVisualizeCommentsPost()
        {
            Application.Run(new VisualizzaCommentiPost(this.email));
        }

        private void openCreatePost()
        {
            Application.Run(new CreaPost(this.email));
        }

        private void openVisualizePost()
        {
            Application.Run(new VisualizzaPost(this.email));
        }

        private void openVisualizeMessage()
        {
            Application.Run(new VisualizzaMessaggi(this.email));
        }

        private void openSendMessage()
        {
            Application.Run(new InvioMessaggio(this.email));
        }

        private void openSendRequestFriend()
        {
            Application.Run(new InviaRichiestaAmicizia(this.email));
        }

        private void openViewfriends()
        {
            Application.Run(new VisualizzaAmici(this.email));
        }

        private void btnInviaMessaggio_Click(object sender, EventArgs e)
        {
            openForm("invioMessaggio");
        }

        private void btnInviaRichiestaAmicizia_Click(object sender, EventArgs e)
        {
            openForm("invioRichiestaAmicizia");
        }

        private void btnVisualizzaMessaggi_Click(object sender, EventArgs e)
        {
            openForm("visualizeMessage");
        }

        private void btnCreaPost_Click(object sender, EventArgs e)
        {
            openForm("createPost");
        }

        private void btnVisualizzaPost_Click(object sender, EventArgs e)
        {
            openForm("visualizePost");
        }

        private void btnVisualizzaCommentiPost_Click(object sender, EventArgs e)
        {
            openForm("visualizeCommentsPost");
        }

        private void btnCreaCommentoPost_Click(object sender, EventArgs e)
        {
            openForm("createCommentPost");
        }

        private void btnVisualizzaProdottiVendita_Click(object sender, EventArgs e)
        {
            openForm("visualizeSaleProdouct");
        }

        private void btnCompraProdotto_Click(object sender, EventArgs e)
        {
            openForm("buySaleProdouct");
        }

        private void btnVendiProdotto_Click(object sender, EventArgs e)
        {
            openForm("sellProduct");
        }

        private void btnEliminaVenditaProdotto_Click(object sender, EventArgs e)
        {
            openForm("deleteSellProduct");
        }

        private void btnVisualizzaProdottiComprati_Click(object sender, EventArgs e)
        {
            openForm("visualizeBuyProduct");
        }

        private void btnVisualizzaProdottiVenduti_Click(object sender, EventArgs e)
        {
            openForm("visualizeSellProduct");
        }

        private void btnVisualizzaProdottiNonVenduti_Click(object sender, EventArgs e)
        {
            openForm("visualizeNotSellProduct");
        }

        private void btnVisualizzaProdottiInVendita_Click(object sender, EventArgs e)
        {
            openForm("visualizeCurrentlySellProduct");
        }

        private void btnCreaSezione_Click(object sender, EventArgs e)
        {
            openForm("createSection");
        }

        private void btnCreaCategoria_Click(object sender, EventArgs e)
        {
            openForm("createCategory");
        }

        private void btnAssociaCategoriaSezione_Click(object sender, EventArgs e)
        {
            openForm("associateCategorySection");
        }

        private void btnTornaLogin_Click(object sender, EventArgs e)
        {
            openForm("returnLogin");
        }

        private void btnAccettaRifiutaRichiestaAmicizia_Click(object sender, EventArgs e)
        {
            openForm("acceptDeclineFriendRequest");
        }

        private void btnCancellaAmicizia_Click(object sender, EventArgs e)
        {
            openForm("deleteFriend");
        }

        private void btnVisualizzaTuttiUtenti_Click(object sender, EventArgs e)
        {
            openForm("visualizeAllUsers");
        }
    }
}
