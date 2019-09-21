namespace SocialNetworkVendite
{
    partial class VisualizzaPost
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
            this.lblVisualizzaPost = new System.Windows.Forms.Label();
            this.lblSezione = new System.Windows.Forms.Label();
            this.cmbbxSezione = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualizzaPost
            // 
            this.lblVisualizzaPost.AutoSize = true;
            this.lblVisualizzaPost.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizzaPost.Location = new System.Drawing.Point(118, 9);
            this.lblVisualizzaPost.Name = "lblVisualizzaPost";
            this.lblVisualizzaPost.Size = new System.Drawing.Size(549, 73);
            this.lblVisualizzaPost.TabIndex = 3;
            this.lblVisualizzaPost.Text = "VISUALIZZA I POST";
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSezione.Location = new System.Drawing.Point(220, 118);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(81, 24);
            this.lblSezione.TabIndex = 36;
            this.lblSezione.Text = "Sezione";
            // 
            // cmbbxSezione
            // 
            this.cmbbxSezione.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSezione.FormattingEnabled = true;
            this.cmbbxSezione.Location = new System.Drawing.Point(321, 117);
            this.cmbbxSezione.Name = "cmbbxSezione";
            this.cmbbxSezione.Size = new System.Drawing.Size(229, 25);
            this.cmbbxSezione.TabIndex = 35;
            this.cmbbxSezione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxSezione_KeyDown);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizza.Location = new System.Drawing.Point(224, 164);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(349, 33);
            this.btnVisualizza.TabIndex = 37;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(760, 258);
            this.dataGridView.TabIndex = 40;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 502);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 41;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // VisualizzaPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lblSezione);
            this.Controls.Add(this.cmbbxSezione);
            this.Controls.Add(this.lblVisualizzaPost);
            this.Name = "VisualizzaPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizzaPost";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizzaPost;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.ComboBox cmbbxSezione;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnHome;
    }
}