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
        //public string conec = @"Data Source=MarcosCozatti\SQLEXPRESS;
        //                      Initial Catalog=BDComercioTi46;
        //                      Persist Security Info=True;
        //                      User ID=sa;Password=senaclivre";

        public string connectionString = @"Data Source=JUN0684686W11-1\BDSENAC; " +
                                      "Initial Catalog=BDComercioTi46; " +
                                      "Persist Security Info=True; " +
                                      "User ID=senaclivre;Password=senaclivre";

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

            itensVendas.idprod = int.Parse(txtidProd.Text);
            itensVendas.Quantidade = int.Parse(txtQtde.Text);
            itensVendas.PrecoUnit = decimal.Parse(txtPrecoUnico.Text);
            itensVendas.Desconto = decimal.Parse(txtDesconto.Text);
            itensVendas.ValorTotalSemDesconto = decimal.Parse(txtTotalSemDesconto.Text);
            itensVendas.ValortotalComDesconto = decimal.Parse(txtTotalComDesconto.Text);


            itensVendas.CadItensVendas();

            dgVendas.DataSource = itensVendas.AtualizaGride(dt, idMestreVendas);
        }


        //Botão para pesquisar um cliente pré existente.
        //nas próximas atualizações, caso o cliente não exista ele abrirá a tela de cadastro.
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            PesquisaClientes cli = new PesquisaClientes();
            cli.ShowDialog();

            txtidCliente.Text = cli.id.ToString();
            txtNomeCliente.Text = cli.Cliente.ToString();
        }


        //Botão para pesquisar um produto pré existente.
        //nas próximas atualizações, caso o produto não exista ele abrirá a tela de cadastro.
        private void btnBuscProd_Click(object sender, EventArgs e)
        {
            PesquisaProdutos pro = new PesquisaProdutos();
            pro.ShowDialog();

            txtidProd.Text = pro.idprod.ToString();
            txtNomeProduto.Text = pro.nomeprod.ToString();
            txtPrecoUnico.Text = pro.valorUnitario.ToString();
            

            //PesquisaProdutos pro = new PesquisaProdutos();
            //if (pro.ShowDialog() == DialogResult.OK && pro.ProdutoSelecionado)
            //{
            //    txtidProd.Text = pro.idprod.ToString();
            //    txtNomeProduto.Text = pro.nomeprod.ToString();
            //}
            // Se o DialogResult não for OK ou nenhum produto foi selecionado,
            // os campos txtidProd e txtNomeProduto permanecem inalterados.

        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoUnico.Text, out decimal precoUnitario) &&
        int.TryParse(txtQtde.Text, out int quantidade))
            {
                decimal totalSemDesconto = precoUnitario * quantidade;
                txtTotalSemDesconto.Text = totalSemDesconto.ToString("N2"); // Formata para duas casas decimais
            }
            else
            {
                txtTotalSemDesconto.Text = string.Empty; // Limpa o campo se a quantidade ou preço for inválido
            }

            // Recalcular o total com desconto se já houver um valor de desconto
            CalculaTotalComDesconto();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalculaTotalComDesconto();
        }

        private void CalculaTotalComDesconto()
        {
            if (decimal.TryParse(txtTotalSemDesconto.Text, out decimal totalSemDesconto))
            {
                if (decimal.TryParse(txtDesconto.Text, out decimal percentualDesconto))
                {
                    // Converter a porcentagem para um valor decimal (ex: 10% = 0.10)
                    decimal descontoDecimal = percentualDesconto / 100;

                    // Calcular o valor do desconto
                    decimal valorDoDesconto = totalSemDesconto * descontoDecimal;

                    // Calcular o total com o desconto aplicado
                    decimal valorComDesconto = totalSemDesconto - valorDoDesconto;

                    txtTotalComDesconto.Text = valorComDesconto.ToString("N2");
                }
                else
                {
                    txtTotalComDesconto.Text = totalSemDesconto.ToString("N2"); // Se desconto inválido, mostra o total sem desconto
                }
            }
            else
            {
                txtTotalComDesconto.Text = string.Empty; // Limpa se o total sem desconto for inválido
            }
        }
    }
}