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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Comercio_02
{
    public partial class PesquisaProdutos : Form
    {
        public PesquisaProdutos()
        {
            InitializeComponent();
        }

        //Replica tabelas Produtos (estoque)
        public int idprod { get; set; }
        public string nomeprod { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime dataProduto { get; set; }
        public decimal valorUnitario { get; set; }
        



        ConectaCli com = new ConectaCli();
        DataTable dt = null;
        readonly string operacao;
        public SqlConnection con = null;
        SqlDataAdapter da = null;

        private void dgPesquisaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idprod = int.Parse(dgPesquisaProdutos.CurrentRow.Cells[0].Value.ToString());
            nomeprod = dgPesquisaProdutos.CurrentRow.Cells[1].Value.ToString();
            marca = dgPesquisaProdutos.CurrentRow.Cells[2].Value.ToString();
            modelo = dgPesquisaProdutos.CurrentRow.Cells[3].Value.ToString();
            dataProduto = DateTime.Parse(dgPesquisaProdutos.CurrentRow.Cells[4].Value.ToString());
            valorUnitario = decimal.Parse(dgPesquisaProdutos.CurrentRow.Cells[5].Value.ToString());
            this.Close();
        }
    }
}
