namespace Comercio_02
{
    partial class PesquisaClientes
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
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.txtpes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Location = new System.Drawing.Point(-1, 24);
            this.dgPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.RowHeadersWidth = 51;
            this.dgPesquisa.RowTemplate.Height = 24;
            this.dgPesquisa.Size = new System.Drawing.Size(426, 206);
            this.dgPesquisa.TabIndex = 3;
            this.dgPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_CellContentClick);
            // 
            // txtpes
            // 
            this.txtpes.Location = new System.Drawing.Point(-1, 1);
            this.txtpes.Margin = new System.Windows.Forms.Padding(2);
            this.txtpes.Name = "txtpes";
            this.txtpes.Size = new System.Drawing.Size(427, 20);
            this.txtpes.TabIndex = 2;
            this.txtpes.TextChanged += new System.EventHandler(this.txtpes_TextChanged);
            // 
            // PesquisaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 232);
            this.Controls.Add(this.dgPesquisa);
            this.Controls.Add(this.txtpes);
            this.Name = "PesquisaClientes";
            this.Text = "PesquisaClientes";
            this.Load += new System.EventHandler(this.PesquisaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.TextBox txtpes;
    }
}