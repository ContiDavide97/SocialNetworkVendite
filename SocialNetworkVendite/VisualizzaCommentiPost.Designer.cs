namespace SocialNetworkVendite
{
    partial class VisualizzaCommentiPost
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
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lblCodicePost = new System.Windows.Forms.Label();
            this.cmbbxPost = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualizzaCommentiPost
            // 
            this.lblVisualizzaCommentiPost.AutoSize = true;
            this.lblVisualizzaCommentiPost.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizzaCommentiPost.Location = new System.Drawing.Point(2, 9);
            this.lblVisualizzaCommentiPost.Name = "lblVisualizzaCommentiPost";
            this.lblVisualizzaCommentiPost.Size = new System.Drawing.Size(775, 55);
            this.lblVisualizzaCommentiPost.TabIndex = 4;
            this.lblVisualizzaCommentiPost.Text = "VISUALIZZA I COMMENTI DI UN POST";
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizza.Location = new System.Drawing.Point(209, 148);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(349, 33);
            this.btnVisualizza.TabIndex = 40;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // lblCodicePost
            // 
            this.lblCodicePost.AutoSize = true;
            this.lblCodicePost.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodicePost.Location = new System.Drawing.Point(203, 98);
            this.lblCodicePost.Name = "lblCodicePost";
            this.lblCodicePost.Size = new System.Drawing.Size(110, 24);
            this.lblCodicePost.TabIndex = 39;
            this.lblCodicePost.Text = "CodicePost";
            // 
            // cmbbxPost
            // 
            this.cmbbxPost.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPost.FormattingEnabled = true;
            this.cmbbxPost.Location = new System.Drawing.Point(329, 97);
            this.cmbbxPost.Name = "cmbbxPost";
            this.cmbbxPost.Size = new System.Drawing.Size(229, 25);
            this.cmbbxPost.TabIndex = 38;
            this.cmbbxPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbxPost_KeyDown);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 505);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(349, 33);
            this.btnHome.TabIndex = 42;
            this.btnHome.Text = "Torna alla Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 207);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(760, 269);
            this.dataGridView.TabIndex = 43;
            // 
            // VisualizzaCommentiPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lblCodicePost);
            this.Controls.Add(this.cmbbxPost);
            this.Controls.Add(this.lblVisualizzaCommentiPost);
            this.Name = "VisualizzaCommentiPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocialNetworkVendite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizzaCommentiPost;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label lblCodicePost;
        private System.Windows.Forms.ComboBox cmbbxPost;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}