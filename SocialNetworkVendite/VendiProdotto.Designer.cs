namespace SocialNetworkVendite
{
    partial class VendiProdotto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVendiProdotto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblSezione = new System.Windows.Forms.Label();
            this.cmbbxSezione = new System.Windows.Forms.ComboBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblImmagineProfilo = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnVendi = new System.Windows.Forms.Button();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVendiProdotto
            // 
            this.lblVendiProdotto.AutoSize = true;
            this.lblVendiProdotto.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendiProdotto.Location = new System.Drawing.Point(155, 9);
            this.lblVendiProdotto.Name = "lblVendiProdotto";
            this.lblVendiProdotto.Size = new System.Drawing.Size(472, 55);
            this.lblVendiProdotto.TabIndex = 8;
            this.lblVendiProdotto.Text = "VENDI UN PRODOTTO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(211, 141);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 24);
            this.lblCategoria.TabIndex = 54;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbbxCategoria
            // 
            this.cmbbxCategoria.Enabled = false;
            this.cmbbxCategoria.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategoria.FormattingEnabled = true;
            this.cmbbxCategoria.Location = new System.Drawing.Point(337, 143);
            this.cmbbxCategoria.Name = "cmbbxCategoria";
            this.cmbbxCategoria.Size = new System.Drawing.Size(229, 25);
            this.cmbbxCategoria.TabIndex = 53;
            this.cmbbxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxCategoria_KeyDown);
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSezione.Location = new System.Drawing.Point(225, 84);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(81, 24);
            this.lblSezione.TabIndex = 52;
            this.lblSezione.Text = "Sezione";
            // 
            // cmbbxSezione
            // 
            this.cmbbxSezione.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSezione.FormattingEnabled = true;
            this.cmbbxSezione.Location = new System.Drawing.Point(337, 83);
            this.cmbbxSezione.Name = "cmbbxSezione";
            this.cmbbxSezione.Size = new System.Drawing.Size(229, 25);
            this.cmbbxSezione.TabIndex = 51;
            this.cmbbxSezione.SelectedValueChanged += new System.EventHandler(this.cmbbxSezione_SelectedValueChanged);
            this.cmbbxSezione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxSezione_KeyDown);
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizione.Location = new System.Drawing.Point(332, 281);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(234, 24);
            this.lblDescrizione.TabIndex = 56;
            this.lblDescrizione.Text = "Descrizione (Facoltativo)";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezzo.Location = new System.Drawing.Point(235, 217);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(71, 24);
            this.lblPrezzo.TabIndex = 58;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezzo.Location = new System.Drawing.Point(337, 216);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(229, 25);
            this.txtPrezzo.TabIndex = 59;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(546, 490);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(158, 138);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 63;
            this.pictureBox.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(302, 543);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(217, 39);
            this.btnImage.TabIndex = 62;
            this.btnImage.Text = "Browse...";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblImmagineProfilo
            // 
            this.lblImmagineProfilo.AutoSize = true;
            this.lblImmagineProfilo.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmagineProfilo.Location = new System.Drawing.Point(2, 558);
            this.lblImmagineProfilo.Name = "lblImmagineProfilo";
            this.lblImmagineProfilo.Size = new System.Drawing.Size(299, 24);
            this.lblImmagineProfilo.TabIndex = 61;
            this.lblImmagineProfilo.Text = "Immagine prodotto (Facoltativo)";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(6, 750);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 64;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnVendi
            // 
            this.btnVendi.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendi.Location = new System.Drawing.Point(239, 663);
            this.btnVendi.Name = "btnVendi";
            this.btnVendi.Size = new System.Drawing.Size(332, 33);
            this.btnVendi.TabIndex = 65;
            this.btnVendi.Text = "Metti in vendita";
            this.btnVendi.UseVisualStyleBackColor = true;
            this.btnVendi.Click += new System.EventHandler(this.btnVendi_Click);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrizione.Location = new System.Drawing.Point(226, 317);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(406, 155);
            this.txtDescrizione.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "€";
            // 
            // VendiProdotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.btnVendi);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.lblImmagineProfilo);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbbxCategoria);
            this.Controls.Add(this.lblSezione);
            this.Controls.Add(this.cmbbxSezione);
            this.Controls.Add(this.lblVendiProdotto);
            this.Name = "VendiProdotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendiProdotto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbbxCategoria;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.ComboBox cmbbxSezione;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblImmagineProfilo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnVendi;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label label1;
    }
}