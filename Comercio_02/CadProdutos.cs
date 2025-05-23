﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Comercio_02
{
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        ConectaProdutos comprod = new ConectaProdutos();

        public string conec = @"Data Source=JUN0684686W11-1\BDSENAC;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        public SqlConnection con = null;
       
        SqlDataAdapter da = null;
        DataTable dt = null;
        string operacao;
        
     

        //Replica tabelas Cadprodutos
        public int idprod { get; set; }
        public string nomeprod { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime dataProduto { get; set; }
        public decimal valorUnitario { get; set; }



        private void btnInserir_Click(object sender, EventArgs e)
        {
            //comprod.idprod = int.Parse(txtidCadproduto.Text);
            comprod.nomeprod = txtProduto.Text;
            comprod.marca = Convert.ToString(txtmarca.Text);
            comprod.modelo = Convert.ToString(txtmodelo.Text);
            comprod.dataProduto = Convert.ToDateTime(txtdatacadproduto.Text);
            comprod.valorUnitario = Convert.ToDecimal(txtValUnit.Text);

            comprod.InserirProdutos();
            limpadados();
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            dgCadprodutos.DataSource = comprod.AtualizaGride(dt);
        }

        private void limpadados()
        {
            txtidCadproduto.Text = string.Empty;
            txtmarca.Text = string.Empty;
            txtmodelo.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtdatacadproduto.Text = string.Empty;  
            txtValUnit.Text = string.Empty;

        }

        private void dgCadClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            comprod.idprod = int.Parse(txtidCadproduto.Text);
            comprod.nomeprod = txtProduto.Text;
            comprod.marca = txtmarca.Text;
            comprod.modelo = txtmodelo.Text;
            comprod.dataProduto = Convert.ToDateTime(txtdatacadproduto.Text);
            if (decimal.TryParse(txtValUnit.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valorUnitario))
            {
                comprod.valorUnitario = valorUnitario;
                comprod.AlterarCadEstoque();
                limpadados();
                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Valor unitário inválido. Utilize o formato correto.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            comprod.idprod = int.Parse(txtidCadproduto.Text);

            comprod.ExcluirEstoque();
            limpadados();
            atualizaGrid();
        }

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void dgCadProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidCadproduto.Text = dgCadprodutos.CurrentRow.Cells[0].Value.ToString();
            txtProduto.Text = dgCadprodutos.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = dgCadprodutos.CurrentRow.Cells[2].Value.ToString();
            txtmodelo.Text = dgCadprodutos.CurrentRow.Cells[3].Value.ToString();
            txtdatacadproduto.Text = dgCadprodutos.CurrentRow.Cells[4].Value.ToString();
            txtValUnit.Text = dgCadprodutos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
