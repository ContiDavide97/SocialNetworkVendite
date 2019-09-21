namespace SocialNetworkVendite
{
    partial class AssociaCategoriaSezione
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
            this.lblAssociaCategoriaSezione = new System.Windows.Forms.Label();
            this.lblNomeCategoria = new System.Windows.Forms.Label();
            this.cmbbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblSezione = new System.Windows.Forms.Label();
            this.cmbbxSezione = new System.Windows.Forms.ComboBox();
            this.btnAssocia = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAssociaCategoriaSezione
            // 
            this.lblAssociaCategoriaSezione.AutoSize = true;
            this.lblAssociaCategoriaSezione.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociaCategoriaSezione.Location = new System.Drawing.Point(12, 9);
            this.lblAssociaCategoriaSezione.Name = "lblAssociaCategoriaSezione";
            this.lblAssociaCategoriaSezione.Size = new System.Drawing.Size(744, 44);
            this.lblAssociaCategoriaSezione.TabIndex = 58;
            this.lblAssociaCategoriaSezione.Text = "ASSOCIA UNA CATEGORIA AD UNA SEZIONE";
            // 
            // lblNomeCategoria
            // 
            this.lblNomeCategoria.AutoSize = true;
            this.lblNomeCategoria.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCategoria.Location = new System.Drawing.Point(204, 221);
            this.lblNomeCategoria.Name = "lblNomeCategoria";
            this.lblNomeCategoria.Size = new System.Drawing.Size(95, 24);
            this.lblNomeCategoria.TabIndex = 60;
            this.lblNomeCategoria.Text = "Categoria";
            // 
            // cmbbxCategoria
            // 
            this.cmbbxCategoria.Enabled = false;
            this.cmbbxCategoria.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategoria.FormattingEnabled = true;
            this.cmbbxCategoria.Location = new System.Drawing.Point(330, 220);
            this.cmbbxCategoria.Name = "cmbbxCategoria";
            this.cmbbxCategoria.Size = new System.Drawing.Size(229, 25);
            this.cmbbxCategoria.TabIndex = 61;
            this.cmbbxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxCategoria_KeyDown);
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSezione.Location = new System.Drawing.Point(218, 153);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(81, 24);
            this.lblSezione.TabIndex = 63;
            this.lblSezione.Text = "Sezione";
            // 
            // cmbbxSezione
            // 
            this.cmbbxSezione.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSezione.FormattingEnabled = true;
            this.cmbbxSezione.Location = new System.Drawing.Point(330, 152);
            this.cmbbxSezione.Name = "cmbbxSezione";
            this.cmbbxSezione.Size = new System.Drawing.Size(229, 25);
            this.cmbbxSezione.TabIndex = 62;
            this.cmbbxSezione.SelectedValueChanged += new System.EventHandler(this.cmbbxSezione_SelectedValueChanged);
            this.cmbbxSezione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxSezione_KeyDown);
            // 
            // btnAssocia
            // 
            this.btnAssocia.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocia.Location = new System.Drawing.Point(237, 296);
            this.btnAssocia.Name = "btnAssocia";
            this.btnAssocia.Size = new System.Drawing.Size(332, 33);
            this.btnAssocia.TabIndex = 66;
            this.btnAssocia.Text = "Associa";
            this.btnAssocia.UseVisualStyleBackColor = true;
            this.btnAssocia.Click += new System.EventHandler(this.btnAssocia_Click);
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
            // AssociaCategoriaSezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAssocia);
            this.Controls.Add(this.lblSezione);
            this.Controls.Add(this.cmbbxSezione);
            this.Controls.Add(this.cmbbxCategoria);
            this.Controls.Add(this.lblNomeCategoria);
            this.Controls.Add(this.lblAssociaCategoriaSezione);
            this.Name = "AssociaCategoriaSezione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssociaCategoriaSezione;
        private System.Windows.Forms.Label lblNomeCategoria;
        private System.Windows.Forms.ComboBox cmbbxCategoria;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.ComboBox cmbbxSezione;
        private System.Windows.Forms.Button btnAssocia;
        private System.Windows.Forms.Button btnHome;
    }
}