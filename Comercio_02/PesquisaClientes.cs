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
    public partial class PesquisaClientes : Form
    {
        public PesquisaClientes()
        {
            InitializeComponent();
        }
        //Replica tabelas
        public int id { get; set; }
        public string Cliente { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime dataCadCli { get; set; }



        ConectaCli com = new ConectaCli();
        DataTable dt = null;
        readonly string operacao;
        public SqlConnection con = null;
        SqlDataAdapter da = null;

        private void dgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgPesquisa.CurrentRow.Cells[0].Value.ToString());
            Cliente = dgPesquisa.CurrentRow.Cells[1].Value.ToString();
            Sobrenome = dgPesquisa.CurrentRow.Cells[2].Value.ToString();
            Telefone = dgPesquisa.CurrentRow.Cells[3].Value.ToString();
            Email = dgPesquisa.CurrentRow.Cells[4].Value.ToString();
            dataCadCli = DateTime.Parse(dgPesquisa.CurrentRow.Cells[5].Value.ToString());
            this.Close();
        }

        private void PesquisaClientes_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            dgPesquisa.DataSource = com.AtualizaGride(dt);
        }

        private void txtpes_TextChanged(object sender, EventArgs e)
        {
            if (txtpes.Text == "")
            {
                atualizaGrid();
                return;
            }
            else
            {
                dgPesquisa.DataSource = com.PesquisaNome(dt, txtpes.Text);

            }
        }
    }
}
