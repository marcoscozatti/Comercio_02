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
        DataTable dt = null;


        ConectaMestreVendas MestreVendas = new ConectaMestreVendas();
        ConectaItensVendas itensVendas = new ConectaItensVendas();





        //Replica tabelas

        //MestreVendas
        public int id_MestreVendas { get; set; }
        public int idcliente { get; set; }
        public int id_prod { get; set; }
        public DateTime DataCompra { get; set; }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MestreVendas.idcliente = int.Parse(txtidCliente.Text);
            MestreVendas.DataCompra = DateTime.Parse(txtDataCompra.Text);


            MestreVendas.CadMestreVendas();



            //limpadados();
            //atualizaGrid();
        }

        private void limpadados()
        {
            txtidProd.Text = "";
            txtidCliente.Text = "";
            txtDataCompra.Text = "";
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itensVendas.id_ItensVendas = int.Parse(txtidProd.Text);

            // Buscar o idMestreVendas gerado
            int idMestreVendas = 
            itensVendas.id_MestreVendas = itensVendas.PegaUltimoIdMestreVendas();

            itensVendas.Quantidade = int.Parse(txtQtde.Text);
            itensVendas.ValorTotal = int.Parse(txtTotalSemDesconto.Text);

            itensVendas.CadItensVendas();

            dgVendas.DataSource = itensVendas.AtualizaGride(dt, idMestreVendas);
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            PesquisaClientes cli = new PesquisaClientes();
            cli.ShowDialog();

            txtidCliente.Text = cli.id.ToString();
            txtNomeCliente.Text = cli.Cliente.ToString();
        }
    }
}