namespace SocialNetworkVendite
{
    partial class VisualizzaAmici
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAmici = new System.Windows.Forms.Label();
            this.listBoxNome = new System.Windows.Forms.ListBox();
            this.listBoxCognome = new System.Windows.Forms.ListBox();
            this.listBoxEmail = new System.Windows.Forms.ListBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 503);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblAmici
            // 
            this.lblAmici.AutoSize = true;
            this.lblAmici.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmici.Location = new System.Drawing.Point(200, 0);
            this.lblAmici.Name = "lblAmici";
            this.lblAmici.Size = new System.Drawing.Size(418, 73);
            this.lblAmici.TabIndex = 8;
            this.lblAmici.Text = "I tuoi amici sono:";
            // 
            // listBoxNome
            // 
            this.listBoxNome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNome.FormattingEnabled = true;
            this.listBoxNome.ItemHeight = 19;
            this.listBoxNome.Location = new System.Drawing.Point(12, 117);
            this.listBoxNome.Name = "listBoxNome";
            this.listBoxNome.Size = new System.Drawing.Size(120, 327);
            this.listBoxNome.TabIndex = 9;
            // 
            // listBoxCognome
            // 
            this.listBoxCognome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCognome.FormattingEnabled = true;
            this.listBoxCognome.ItemHeight = 19;
            this.listBoxCognome.Location = new System.Drawing.Point(241, 117);
            this.listBoxCognome.Name = "listBoxCognome";
            this.listBoxCognome.Size = new System.Drawing.Size(120, 327);
            this.listBoxCognome.TabIndex = 10;
            // 
            // listBoxEmail
            // 
            this.listBoxEmail.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmail.FormattingEnabled = true;
            this.listBoxEmail.ItemHeight = 19;
            this.listBoxEmail.Location = new System.Drawing.Point(452, 117);
            this.listBoxEmail.Name = "listBoxEmail";
            this.listBoxEmail.Size = new System.Drawing.Size(302, 327);
            this.listBoxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(566, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 24);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(250, 90);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(97, 24);
            this.lblCognome.TabIndex = 30;
            this.lblCognome.Text = "Cognome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Nome";
            // 
            // VisualizzaAmici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.listBoxEmail);
            this.Controls.Add(this.listBoxCognome);
            this.Controls.Add(this.listBoxNome);
            this.Controls.Add(this.lblAmici);
            this.Controls.Add(this.btnHome);
            this.Name = "VisualizzaAmici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblAmici;
        private System.Windows.Forms.ListBox listBoxNome;
        private System.Windows.Forms.ListBox listBoxCognome;
        private System.Windows.Forms.ListBox listBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNome;
    }
}