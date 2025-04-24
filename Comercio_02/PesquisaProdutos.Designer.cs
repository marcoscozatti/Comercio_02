namespace Comercio_02
{
    partial class PesquisaProdutos
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
            this.dgPesquisaProdutos = new System.Windows.Forms.DataGridView();
            this.txtPesquisaProdutos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPesquisaProdutos
            // 
            this.dgPesquisaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisaProdutos.Location = new System.Drawing.Point(0, 27);
            this.dgPesquisaProdutos.Name = "dgPesquisaProdutos";
            this.dgPesquisaProdutos.Size = new System.Drawing.Size(391, 338);
            this.dgPesquisaProdutos.TabIndex = 0;
            this.dgPesquisaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisaProdutos_CellContentClick);
            // 
            // txtPesquisaProdutos
            // 
            this.txtPesquisaProdutos.Location = new System.Drawing.Point(0, 1);
            this.txtPesquisaProdutos.Name = "txtPesquisaProdutos";
            this.txtPesquisaProdutos.Size = new System.Drawing.Size(391, 20);
            this.txtPesquisaProdutos.TabIndex = 1;
            this.txtPesquisaProdutos.TextChanged += new System.EventHandler(this.txtPesquisaProdutos_TextChanged);
            // 
            // PesquisaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 365);
            this.Controls.Add(this.txtPesquisaProdutos);
            this.Controls.Add(this.dgPesquisaProdutos);
            this.Name = "PesquisaProdutos";
            this.Text = "PesquisaProdutos";
            this.Load += new System.EventHandler(this.PesquisaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPesquisaProdutos;
        private System.Windows.Forms.TextBox txtPesquisaProdutos;
    }
}