namespace SocialNetworkVendite
{
    partial class AccettaRifiutaRichiestaAmicizia
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
            this.cmbbxEmailUtente = new System.Windows.Forms.ComboBox();
            this.lblEmailUtente = new System.Windows.Forms.Label();
            this.btnAccetta = new System.Windows.Forms.Button();
            this.btnRifiusta = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 41);
            this.label1.TabIndex = 37;
            this.label1.Text = "ACCETTA/RIFIUTA UNA RICHIESTA DI AMICIZIA";
            // 
            // cmbbxEmailUtente
            // 
            this.cmbbxEmailUtente.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxEmailUtente.FormattingEnabled = true;
            this.cmbbxEmailUtente.Location = new System.Drawing.Point(342, 197);
            this.cmbbxEmailUtente.Name = "cmbbxEmailUtente";
            this.cmbbxEmailUtente.Size = new System.Drawing.Size(229, 25);
            this.cmbbxEmailUtente.TabIndex = 41;
            // 
            // lblEmailUtente
            // 
            this.lblEmailUtente.AutoSize = true;
            this.lblEmailUtente.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUtente.Location = new System.Drawing.Point(181, 198);
            this.lblEmailUtente.Name = "lblEmailUtente";
            this.lblEmailUtente.Size = new System.Drawing.Size(125, 24);
            this.lblEmailUtente.TabIndex = 51;
            this.lblEmailUtente.Text = "Email utente";
            // 
            // btnAccetta
            // 
            this.btnAccetta.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccetta.Location = new System.Drawing.Point(409, 279);
            this.btnAccetta.Name = "btnAccetta";
            this.btnAccetta.Size = new System.Drawing.Size(202, 33);
            this.btnAccetta.TabIndex = 58;
            this.btnAccetta.Text = "Accetta";
            this.btnAccetta.UseVisualStyleBackColor = true;
            this.btnAccetta.Click += new System.EventHandler(this.btnAccetta_Click);
            // 
            // btnRifiusta
            // 
            this.btnRifiusta.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRifiusta.Location = new System.Drawing.Point(162, 279);
            this.btnRifiusta.Name = "btnRifiusta";
            this.btnRifiusta.Size = new System.Drawing.Size(194, 33);
            this.btnRifiusta.TabIndex = 59;
            this.btnRifiusta.Text = "Rifiuta";
            this.btnRifiusta.UseVisualStyleBackColor = true;
            this.btnRifiusta.Click += new System.EventHandler(this.btnRifiusta_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 505);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 68;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AccettaRifiutaRichiestaAmicizia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRifiusta);
            this.Controls.Add(this.btnAccetta);
            this.Controls.Add(this.lblEmailUtente);
            this.Controls.Add(this.cmbbxEmailUtente);
            this.Controls.Add(this.label1);
            this.Name = "AccettaRifiutaRichiestaAmicizia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxEmailUtente;
        private System.Windows.Forms.Label lblEmailUtente;
        private System.Windows.Forms.Button btnAccetta;
        private System.Windows.Forms.Button btnRifiusta;
        private System.Windows.Forms.Button btnHome;
    }
}