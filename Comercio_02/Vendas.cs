using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }
        public string conec = @"Data Source=MarcosCozatti\SQLEXPRESS;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=sa;Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;


        ConectaMestreVendas MestreVendas = new ConectaMestreVendas();




        //Replica tabelas

        //MestreVendas
        public int id_MestreVendas { get; set; }
        public int idcliente { get; set; }
        public int id_prod { get; set; }
        public DateTime DataCompra { get; set; }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MestreVendas.id_prod = int.Parse(txtidProd.Text);
            MestreVendas.idcliente = int.Parse(txtidCliente.Text);
            MestreVendas.DataCompra = DateTime.Parse(txtDataCompra.Text);
            

            MestreVendas.InserirCadcli();
           //limpadados();
           //atualizaGrid();
        }

        private void limpadados()
        {
            txtidProd.Text = "";
            txtidCliente.Text = "";
            txtDataCompra.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //botao de sacola
        }
    }
}
