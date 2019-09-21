namespace SocialNetworkVendite
{
    partial class CreaPost
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
            this.lblCreaPost = new System.Windows.Forms.Label();
            this.lblSezione = new System.Windows.Forms.Label();
            this.cmbbxSezione = new System.Windows.Forms.ComboBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreaPost
            // 
            this.lblCreaPost.AutoSize = true;
            this.lblCreaPost.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaPost.Location = new System.Drawing.Point(180, 9);
            this.lblCreaPost.Name = "lblCreaPost";
            this.lblCreaPost.Size = new System.Drawing.Size(435, 73);
            this.lblCreaPost.TabIndex = 4;
            this.lblCreaPost.Text = "CREA UN POST";
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSezione.Location = new System.Drawing.Point(215, 119);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(81, 24);
            this.lblSezione.TabIndex = 38;
            this.lblSezione.Text = "Sezione";
            // 
            // cmbbxSezione
            // 
            this.cmbbxSezione.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSezione.FormattingEnabled = true;
            this.cmbbxSezione.Location = new System.Drawing.Point(302, 118);
            this.cmbbxSezione.Name = "cmbbxSezione";
            this.cmbbxSezione.Size = new System.Drawing.Size(229, 25);
            this.cmbbxSezione.TabIndex = 37;
            this.cmbbxSezione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxSezione_KeyDown);
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(215, 170);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(64, 24);
            this.lblTitolo.TabIndex = 40;
            this.lblTitolo.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Descrizione";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 504);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 44;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtTitolo
            // 
            this.txtTitolo.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitolo.Location = new System.Drawing.Point(301, 169);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(227, 25);
            this.txtTitolo.TabIndex = 45;
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(193, 246);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(406, 155);
            this.txtMessaggio.TabIndex = 46;
            // 
            // btnInvia
            // 
            this.btnInvia.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvia.Location = new System.Drawing.Point(222, 425);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(349, 33);
            this.btnInvia.TabIndex = 47;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // CreaPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblSezione);
            this.Controls.Add(this.cmbbxSezione);
            this.Controls.Add(this.lblCreaPost);
            this.Name = "CreaPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreaPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreaPost;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.ComboBox cmbbxSezione;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Button btnInvia;
    }
}