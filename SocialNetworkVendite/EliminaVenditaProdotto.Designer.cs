namespace SocialNetworkVendite
{
    partial class EliminaVenditaProdotto
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodiceProdotto = new System.Windows.Forms.Label();
            this.cmbbxCodiceProdotto = new System.Windows.Forms.ComboBox();
            this.btnEliminaVendita = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "ELIMINA UN PRODOTTO IN VENDITA";
            // 
            // lblCodiceProdotto
            // 
            this.lblCodiceProdotto.AutoSize = true;
            this.lblCodiceProdotto.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiceProdotto.Location = new System.Drawing.Point(166, 220);
            this.lblCodiceProdotto.Name = "lblCodiceProdotto";
            this.lblCodiceProdotto.Size = new System.Drawing.Size(151, 24);
            this.lblCodiceProdotto.TabIndex = 38;
            this.lblCodiceProdotto.Text = "Codice prodotto";
            // 
            // cmbbxCodiceProdotto
            // 
            this.cmbbxCodiceProdotto.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCodiceProdotto.FormattingEnabled = true;
            this.cmbbxCodiceProdotto.Location = new System.Drawing.Point(348, 219);
            this.cmbbxCodiceProdotto.Name = "cmbbxCodiceProdotto";
            this.cmbbxCodiceProdotto.Size = new System.Drawing.Size(229, 25);
            this.cmbbxCodiceProdotto.TabIndex = 37;
            this.cmbbxCodiceProdotto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxCodiceProdotto_KeyDown);
            // 
            // btnEliminaVendita
            // 
            this.btnEliminaVendita.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaVendita.Location = new System.Drawing.Point(213, 287);
            this.btnEliminaVendita.Name = "btnEliminaVendita";
            this.btnEliminaVendita.Size = new System.Drawing.Size(332, 33);
            this.btnEliminaVendita.TabIndex = 46;
            this.btnEliminaVendita.Text = "Elimina vendita";
            this.btnEliminaVendita.UseVisualStyleBackColor = true;
            this.btnEliminaVendita.Click += new System.EventHandler(this.btnEliminaVendita_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(15, 501);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 47;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // EliminaVenditaProdotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEliminaVendita);
            this.Controls.Add(this.lblCodiceProdotto);
            this.Controls.Add(this.cmbbxCodiceProdotto);
            this.Controls.Add(this.label1);
            this.Name = "EliminaVenditaProdotto";
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodiceProdotto;
        private System.Windows.Forms.ComboBox cmbbxCodiceProdotto;
        private System.Windows.Forms.Button btnEliminaVendita;
        private System.Windows.Forms.Button btnHome;
    }
}