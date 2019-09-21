namespace SocialNetworkVendite
{
    partial class VisualizzaProdottiComprati
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
            this.lblProdottiComprati = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdottiComprati
            // 
            this.lblProdottiComprati.AutoSize = true;
            this.lblProdottiComprati.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdottiComprati.Location = new System.Drawing.Point(129, 9);
            this.lblProdottiComprati.Name = "lblProdottiComprati";
            this.lblProdottiComprati.Size = new System.Drawing.Size(468, 55);
            this.lblProdottiComprati.TabIndex = 5;
            this.lblProdottiComprati.Text = "PRODOTTI COMPRATI";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(760, 373);
            this.dataGridView.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 504);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 48;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // VisualizzaProdottiComprati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblProdottiComprati);
            this.Name = "VisualizzaProdottiComprati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdottiComprati;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnHome;
    }
}