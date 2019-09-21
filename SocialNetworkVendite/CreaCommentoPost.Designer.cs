namespace SocialNetworkVendite
{
    partial class InviaCommentoPost
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
            this.lblVisualizzaCommentiPost = new System.Windows.Forms.Label();
            this.lblCodicePost = new System.Windows.Forms.Label();
            this.cmbbxPost = new System.Windows.Forms.ComboBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVisualizzaCommentiPost
            // 
            this.lblVisualizzaCommentiPost.AutoSize = true;
            this.lblVisualizzaCommentiPost.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizzaCommentiPost.Location = new System.Drawing.Point(35, 9);
            this.lblVisualizzaCommentiPost.Name = "lblVisualizzaCommentiPost";
            this.lblVisualizzaCommentiPost.Size = new System.Drawing.Size(719, 55);
            this.lblVisualizzaCommentiPost.TabIndex = 5;
            this.lblVisualizzaCommentiPost.Text = "INVIA UN COMMENTO IN UN POST";
            // 
            // lblCodicePost
            // 
            this.lblCodicePost.AutoSize = true;
            this.lblCodicePost.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodicePost.Location = new System.Drawing.Point(200, 110);
            this.lblCodicePost.Name = "lblCodicePost";
            this.lblCodicePost.Size = new System.Drawing.Size(110, 24);
            this.lblCodicePost.TabIndex = 41;
            this.lblCodicePost.Text = "CodicePost";
            // 
            // cmbbxPost
            // 
            this.cmbbxPost.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPost.FormattingEnabled = true;
            this.cmbbxPost.Location = new System.Drawing.Point(326, 109);
            this.cmbbxPost.Name = "cmbbxPost";
            this.cmbbxPost.Size = new System.Drawing.Size(229, 25);
            this.cmbbxPost.TabIndex = 40;
            this.cmbbxPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxPost_KeyDown);
            // 
            // btnInvia
            // 
            this.btnInvia.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvia.Location = new System.Drawing.Point(218, 386);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(349, 33);
            this.btnInvia.TabIndex = 43;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(186, 191);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(406, 155);
            this.txtMessaggio.TabIndex = 42;
            // 
            // lblMessaggio
            // 
            this.lblMessaggio.AutoSize = true;
            this.lblMessaggio.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessaggio.Location = new System.Drawing.Point(346, 152);
            this.lblMessaggio.Name = "lblMessaggio";
            this.lblMessaggio.Size = new System.Drawing.Size(103, 24);
            this.lblMessaggio.TabIndex = 44;
            this.lblMessaggio.Text = "Messaggio";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 503);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 45;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // InviaCommentoPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.lblCodicePost);
            this.Controls.Add(this.cmbbxPost);
            this.Controls.Add(this.lblVisualizzaCommentiPost);
            this.Name = "InviaCommentoPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizzaCommentiPost;
        private System.Windows.Forms.Label lblCodicePost;
        private System.Windows.Forms.ComboBox cmbbxPost;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Label lblMessaggio;
        private System.Windows.Forms.Button btnHome;
    }
}