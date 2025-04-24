using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Comercio_02
{
    class ConectaProdutos
    {

        public string conec = @"Data Source=JUN0684686W11-1\BDSENAC;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas Cadprodutos
        public int idprod { get; set; }
        public string nomeprod { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime dataProduto { get; set; }
        public decimal valorUnitario { get; set; }



        //CRUD CADESTOQUE
        public void InserirProdutos()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "INSERT INTO cadprodutos (nomeprod, marca, modelo, dataProduto, valorUnitario) " +
                "VALUES (@nomeprod, @marca, @modelo, @dataProduto, @valorUnitario)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nomeprod", nomeprod);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@dataProduto", dataProduto);
            cmd.Parameters.AddWithValue("@valorUnitario", valorUnitario);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro adicionado!");
            con.Close();

        }

        public void AlterarCadEstoque()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "update cadprodutos set nomeprod = @nomeprod, " +
                "marca=@marca, modelo=@modelo, dataproduto=@dataProduto, valorUnitario=@valorUnitario where idprod = @idprod";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idprod", idprod);
            cmd.Parameters.AddWithValue("@nomeprod", nomeprod);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@dataProduto", dataProduto);
            cmd.Parameters.AddWithValue("@valorUnitario", valorUnitario);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Alterado!");
            con.Close();
        }


        //ExcluirCadEstoque
        public void ExcluirEstoque()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "DELETE FROM cadprodutos WHERE idprod=@idprod";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idprod", idprod);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Excluido!");
            con.Close();
        }


        public DataTable AtualizaGride(DataTable x)
        {
            string strSql;
            strSql = "SELECT * FROM cadprodutos";

            con = new SqlConnection(conec);
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return x;

        }

        public DataTable PesquisaProduto(DataTable x, string txtPes)
        {
            string strSql;
            strSql = "SELECT * FROM cadprodutos WHERE nomeprod LIKE '%" + txtPes + "%'";
            con = new SqlConnection(conec);
            da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return (x);
        }


    }
}
