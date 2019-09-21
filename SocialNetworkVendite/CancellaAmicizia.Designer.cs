namespace SocialNetworkVendite
{
    partial class CancellaAmicizia
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
            this.lblCancellaAmicizia = new System.Windows.Forms.Label();
            this.lblEmailUtente = new System.Windows.Forms.Label();
            this.cmbbxEmailUtente = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCancellaAmicizia
            // 
            this.lblCancellaAmicizia.AutoSize = true;
            this.lblCancellaAmicizia.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancellaAmicizia.Location = new System.Drawing.Point(34, 9);
            this.lblCancellaAmicizia.Name = "lblCancellaAmicizia";
            this.lblCancellaAmicizia.Size = new System.Drawing.Size(725, 73);
            this.lblCancellaAmicizia.TabIndex = 4;
            this.lblCancellaAmicizia.Text = "CANCELLA UN\'AMICIZIA";
            // 
            // lblEmailUtente
            // 
            this.lblEmailUtente.AutoSize = true;
            this.lblEmailUtente.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUtente.Location = new System.Drawing.Point(190, 201);
            this.lblEmailUtente.Name = "lblEmailUtente";
            this.lblEmailUtente.Size = new System.Drawing.Size(125, 24);
            this.lblEmailUtente.TabIndex = 61;
            this.lblEmailUtente.Text = "Email utente";
            // 
            // cmbbxEmailUtente
            // 
            this.cmbbxEmailUtente.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxEmailUtente.FormattingEnabled = true;
            this.cmbbxEmailUtente.Location = new System.Drawing.Point(351, 200);
            this.cmbbxEmailUtente.Name = "cmbbxEmailUtente";
            this.cmbbxEmailUtente.Size = new System.Drawing.Size(229, 25);
            this.cmbbxEmailUtente.TabIndex = 60;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 501);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 63;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancella.Location = new System.Drawing.Point(218, 284);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(349, 33);
            this.btnCancella.TabIndex = 62;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // CancellaAmicizia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.lblEmailUtente);
            this.Controls.Add(this.cmbbxEmailUtente);
            this.Controls.Add(this.lblCancellaAmicizia);
            this.Name = "CancellaAmicizia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancellaAmicizia;
        private System.Windows.Forms.Label lblEmailUtente;
        private System.Windows.Forms.ComboBox cmbbxEmailUtente;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCancella;
    }
}