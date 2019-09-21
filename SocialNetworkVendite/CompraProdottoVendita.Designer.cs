namespace SocialNetworkVendite
{
    partial class CompraProdottoVendita
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
            this.lblCompraProdottoVendita = new System.Windows.Forms.Label();
            this.lblCodiceProdotto = new System.Windows.Forms.Label();
            this.cmbbxCodiceProdotto = new System.Windows.Forms.ComboBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblSezione = new System.Windows.Forms.Label();
            this.cmbbxSezione = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCompraProdottoVendita
            // 
            this.lblCompraProdottoVendita.AutoSize = true;
            this.lblCompraProdottoVendita.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompraProdottoVendita.Location = new System.Drawing.Point(12, 9);
            this.lblCompraProdottoVendita.Name = "lblCompraProdottoVendita";
            this.lblCompraProdottoVendita.Size = new System.Drawing.Size(780, 55);
            this.lblCompraProdottoVendita.TabIndex = 7;
            this.lblCompraProdottoVendita.Text = "COMPRA UN PRODOTTO IN VENDITA";
            // 
            // lblCodiceProdotto
            // 
            this.lblCodiceProdotto.AutoSize = true;
            this.lblCodiceProdotto.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiceProdotto.Location = new System.Drawing.Point(158, 276);
            this.lblCodiceProdotto.Name = "lblCodiceProdotto";
            this.lblCodiceProdotto.Size = new System.Drawing.Size(151, 24);
            this.lblCodiceProdotto.TabIndex = 36;
            this.lblCodiceProdotto.Text = "Codice prodotto";
            // 
            // cmbbxCodiceProdotto
            // 
            this.cmbbxCodiceProdotto.Enabled = false;
            this.cmbbxCodiceProdotto.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCodiceProdotto.FormattingEnabled = true;
            this.cmbbxCodiceProdotto.Location = new System.Drawing.Point(340, 275);
            this.cmbbxCodiceProdotto.Name = "cmbbxCodiceProdotto";
            this.cmbbxCodiceProdotto.Size = new System.Drawing.Size(229, 25);
            this.cmbbxCodiceProdotto.TabIndex = 35;
            this.cmbbxCodiceProdotto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxCodiceProdotto_KeyDown);
            // 
            // btnCompra
            // 
            this.btnCompra.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Location = new System.Drawing.Point(218, 339);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(332, 33);
            this.btnCompra.TabIndex = 45;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 500);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(214, 212);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 24);
            this.lblCategoria.TabIndex = 50;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbbxCategoria
            // 
            this.cmbbxCategoria.Enabled = false;
            this.cmbbxCategoria.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategoria.FormattingEnabled = true;
            this.cmbbxCategoria.Location = new System.Drawing.Point(340, 214);
            this.cmbbxCategoria.Name = "cmbbxCategoria";
            this.cmbbxCategoria.Size = new System.Drawing.Size(229, 25);
            this.cmbbxCategoria.TabIndex = 49;
            this.cmbbxCategoria.SelectedValueChanged += new System.EventHandler(this.cmbbxCategoria_SelectedValueChanged);
            this.cmbbxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxCategoria_KeyDown);
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSezione.Location = new System.Drawing.Point(228, 155);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(81, 24);
            this.lblSezione.TabIndex = 48;
            this.lblSezione.Text = "Sezione";
            // 
            // cmbbxSezione
            // 
            this.cmbbxSezione.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSezione.FormattingEnabled = true;
            this.cmbbxSezione.Location = new System.Drawing.Point(340, 154);
            this.cmbbxSezione.Name = "cmbbxSezione";
            this.cmbbxSezione.Size = new System.Drawing.Size(229, 25);
            this.cmbbxSezione.TabIndex = 47;
            this.cmbbxSezione.SelectedValueChanged += new System.EventHandler(this.cmbbxSezione_SelectedValueChanged);
            this.cmbbxSezione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxSezione_KeyDown);
            // 
            // CompraProdottoVendita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbbxCategoria);
            this.Controls.Add(this.lblSezione);
            this.Controls.Add(this.cmbbxSezione);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.lblCodiceProdotto);
            this.Controls.Add(this.cmbbxCodiceProdotto);
            this.Controls.Add(this.lblCompraProdottoVendita);
            this.Name = "CompraProdottoVendita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompraProdottoVendita;
        private System.Windows.Forms.Label lblCodiceProdotto;
        private System.Windows.Forms.ComboBox cmbbxCodiceProdotto;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbbxCategoria;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.ComboBox cmbbxSezione;
    }
}