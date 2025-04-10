namespace Comercio_02
{
    partial class Vendas
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblprecounit = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btnBuscProd = new System.Windows.Forms.Button();
            this.txtPrecoUnico = new System.Windows.Forms.TextBox();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.txtTotalComDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalSemDesconto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtidProd = new System.Windows.Forms.TextBox();
            this.txtidVendas = new System.Windows.Forms.TextBox();
            this.lbltotalcomDesconto = new System.Windows.Forms.Label();
            this.lbltotalsemdesconto = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.lbldatacompra = new System.Windows.Forms.Label();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblIDVendas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 133);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDAS";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(248, 503);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 30);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(166, 503);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(161, 183);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(77, 16);
            this.lblQtde.TabIndex = 7;
            this.lblQtde.Text = "Quantidade";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(33, 503);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 52);
            this.btnAdicionar.TabIndex = 28;
            this.btnAdicionar.Text = "Adicionar Mestre";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblprecounit
            // 
            this.lblprecounit.AutoSize = true;
            this.lblprecounit.Location = new System.Drawing.Point(265, 183);
            this.lblprecounit.Name = "lblprecounit";
            this.lblprecounit.Size = new System.Drawing.Size(92, 16);
            this.lblprecounit.TabIndex = 9;
            this.lblprecounit.Text = "Preço Unitário";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(197, 123);
            this.btnBuscaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaCliente.TabIndex = 27;
            this.btnBuscaCliente.Text = "...";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(164, 213);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(79, 22);
            this.txtQtde.TabIndex = 23;
            // 
            // btnBuscProd
            // 
            this.btnBuscProd.Location = new System.Drawing.Point(617, 123);
            this.btnBuscProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscProd.Name = "btnBuscProd";
            this.btnBuscProd.Size = new System.Drawing.Size(28, 23);
            this.btnBuscProd.TabIndex = 26;
            this.btnBuscProd.Text = "...";
            this.btnBuscProd.UseVisualStyleBackColor = true;
            // 
            // txtPrecoUnico
            // 
            this.txtPrecoUnico.Location = new System.Drawing.Point(265, 213);
            this.txtPrecoUnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecoUnico.Name = "txtPrecoUnico";
            this.txtPrecoUnico.Size = new System.Drawing.Size(95, 22);
            this.txtPrecoUnico.TabIndex = 22;
            // 
            // dgVendas
            // 
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Location = new System.Drawing.Point(24, 250);
            this.dgVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.RowHeadersWidth = 51;
            this.dgVendas.RowTemplate.Height = 24;
            this.dgVendas.Size = new System.Drawing.Size(989, 247);
            this.dgVendas.TabIndex = 25;
            // 
            // txtTotalComDesconto
            // 
            this.txtTotalComDesconto.Location = new System.Drawing.Point(671, 213);
            this.txtTotalComDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalComDesconto.Name = "txtTotalComDesconto";
            this.txtTotalComDesconto.Size = new System.Drawing.Size(140, 22);
            this.txtTotalComDesconto.TabIndex = 21;
            // 
            // txtTotalSemDesconto
            // 
            this.txtTotalSemDesconto.Location = new System.Drawing.Point(508, 213);
            this.txtTotalSemDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalSemDesconto.Name = "txtTotalSemDesconto";
            this.txtTotalSemDesconto.Size = new System.Drawing.Size(140, 22);
            this.txtTotalSemDesconto.TabIndex = 20;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(387, 213);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(95, 22);
            this.txtDesconto.TabIndex = 19;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(36, 213);
            this.txtDataCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(109, 22);
            this.txtDataCompra.TabIndex = 24;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(232, 155);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(337, 22);
            this.txtNomeCliente.TabIndex = 18;
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(139, 155);
            this.txtidCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(87, 22);
            this.txtidCliente.TabIndex = 17;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(655, 155);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(343, 22);
            this.txtNomeProduto.TabIndex = 16;
            // 
            // txtidProd
            // 
            this.txtidProd.Location = new System.Drawing.Point(573, 155);
            this.txtidProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(75, 22);
            this.txtidProd.TabIndex = 15;
            // 
            // txtidVendas
            // 
            this.txtidVendas.Location = new System.Drawing.Point(36, 155);
            this.txtidVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidVendas.Name = "txtidVendas";
            this.txtidVendas.Size = new System.Drawing.Size(75, 22);
            this.txtidVendas.TabIndex = 14;
            // 
            // lbltotalcomDesconto
            // 
            this.lbltotalcomDesconto.AutoSize = true;
            this.lbltotalcomDesconto.Location = new System.Drawing.Point(667, 187);
            this.lbltotalcomDesconto.Name = "lbltotalcomDesconto";
            this.lbltotalcomDesconto.Size = new System.Drawing.Size(128, 16);
            this.lbltotalcomDesconto.TabIndex = 12;
            this.lbltotalcomDesconto.Text = "Total com Desconto";
            // 
            // lbltotalsemdesconto
            // 
            this.lbltotalsemdesconto.AutoSize = true;
            this.lbltotalsemdesconto.Location = new System.Drawing.Point(505, 183);
            this.lbltotalsemdesconto.Name = "lbltotalsemdesconto";
            this.lbltotalsemdesconto.Size = new System.Drawing.Size(128, 16);
            this.lbltotalsemdesconto.TabIndex = 11;
            this.lbltotalsemdesconto.Text = "Total sem Desconto";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(391, 183);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(65, 16);
            this.lbldesconto.TabIndex = 10;
            this.lbldesconto.Text = "Desconto";
            // 
            // lbldatacompra
            // 
            this.lbldatacompra.AutoSize = true;
            this.lbldatacompra.Location = new System.Drawing.Point(33, 183);
            this.lbldatacompra.Name = "lbldatacompra";
            this.lbldatacompra.Size = new System.Drawing.Size(84, 16);
            this.lbldatacompra.TabIndex = 8;
            this.lbldatacompra.Text = "DataCompra";
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(136, 126);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(61, 16);
            this.lblidcliente.TabIndex = 6;
            this.lblidcliente.Text = "IDCliente";
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Location = new System.Drawing.Point(571, 126);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(49, 16);
            this.lblIDProd.TabIndex = 13;
            this.lblIDProd.Text = "IDProd";
            // 
            // lblIDVendas
            // 
            this.lblIDVendas.AutoSize = true;
            this.lblIDVendas.Location = new System.Drawing.Point(33, 123);
            this.lblIDVendas.Name = "lblIDVendas";
            this.lblIDVendas.Size = new System.Drawing.Size(20, 16);
            this.lblIDVendas.TabIndex = 5;
            this.lblIDVendas.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercio_02.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(873, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblprecounit);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.btnBuscProd);
            this.Controls.Add(this.txtPrecoUnico);
            this.Controls.Add(this.dgVendas);
            this.Controls.Add(this.txtTotalComDesconto);
            this.Controls.Add(this.txtTotalSemDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtidProd);
            this.Controls.Add(this.txtidVendas);
            this.Controls.Add(this.lbltotalcomDesconto);
            this.Controls.Add(this.lbltotalsemdesconto);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lbldatacompra);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblIDVendas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblprecounit;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btnBuscProd;
        private System.Windows.Forms.TextBox txtPrecoUnico;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.TextBox txtTotalComDesconto;
        private System.Windows.Forms.TextBox txtTotalSemDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtidProd;
        private System.Windows.Forms.TextBox txtidVendas;
        private System.Windows.Forms.Label lbltotalcomDesconto;
        private System.Windows.Forms.Label lbltotalsemdesconto;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.Label lbldatacompra;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblIDVendas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}