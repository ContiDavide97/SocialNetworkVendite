namespace SocialNetworkVendite
{
    partial class VisualizzaProdottiAttualmenteInVendita
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblProdottiAttualmenteInVendita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 517);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 57;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 102);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(760, 373);
            this.dataGridView.TabIndex = 56;
            // 
            // lblProdottiAttualmenteInVendita
            // 
            this.lblProdottiAttualmenteInVendita.AutoSize = true;
            this.lblProdottiAttualmenteInVendita.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdottiAttualmenteInVendita.Location = new System.Drawing.Point(75, 21);
            this.lblProdottiAttualmenteInVendita.Name = "lblProdottiAttualmenteInVendita";
            this.lblProdottiAttualmenteInVendita.Size = new System.Drawing.Size(625, 44);
            this.lblProdottiAttualmenteInVendita.TabIndex = 55;
            this.lblProdottiAttualmenteInVendita.Text = "PRODOTTI ATTUALMENTE IN VENDITA";
            // 
            // VisualizzaProdottiAttualmenteInVendita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblProdottiAttualmenteInVendita);
            this.Name = "VisualizzaProdottiAttualmenteInVendita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblProdottiAttualmenteInVendita;
    }
}