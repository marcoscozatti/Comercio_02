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
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }

        ConectaCli comcli = new ConectaCli();

        DataTable dt = null;
        string operacao;
        public SqlConnection con = null;
        SqlDataAdapter da = null;

        public int id { get; set; }
        public string Cliente { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime dataCadCli { get; set; }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            comcli.Cliente = txtcliente.Text;
            comcli.Sobrenome = txtsobrenome.Text;
            comcli.Telefone = txttelefone.Text;
            comcli.Email = txtemail.Text;
            comcli.dataCadCli = Convert.ToDateTime(txtdata.Text);

            comcli.InserirCadcli();
            limpadados();
            atualizaGrid();
        }

        private void limpadados()
        {
            txtidcliente.Text = "";
            txtcliente.Text = "";
            txtsobrenome.Text = "";
            txttelefone.Text = "";
            txtemail.Text = "";
            txtdata.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            comcli.id = int.Parse(txtidcliente.Text);
            comcli.Cliente = txtcliente.Text;
            comcli.Sobrenome = txtsobrenome.Text;
            comcli.Telefone = txttelefone.Text;
            comcli.Email = txtemail.Text;
            comcli.dataCadCli = Convert.ToDateTime(txtdata.Text);

            comcli.AlterarCadcli();
            limpadados();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            comcli.id = int.Parse(txtidcliente.Text);

            comcli.ExcluirCadcli();
            limpadados();
            atualizaGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
    
        }

        private void dgCadClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcliente.Text = dgCadClientes.CurrentRow.Cells[0].Value.ToString();
            txtcliente.Text = dgCadClientes.CurrentRow.Cells[1].Value.ToString();
            txtsobrenome.Text = dgCadClientes.CurrentRow.Cells[2].Value.ToString();
            txttelefone.Text = dgCadClientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgCadClientes.CurrentRow.Cells[4].Value.ToString();
            txtdata.Text = dgCadClientes.CurrentRow.Cells[5].Value.ToString();
            
        }


        public void atualizaGrid()
        {
            dgCadClientes.DataSource = comcli.AtualizaGride(dt);

        }

        private void CadClientes_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void txtPesquisaCadCli_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaCadCli.Text == "")
            {
                atualizaGrid();
                return;
            }
            else
            {
                dgCadClientes.DataSource = comcli.PesquisaNome(dt, txtPesquisaCadCli.Text);

            }
        }
    }
}
