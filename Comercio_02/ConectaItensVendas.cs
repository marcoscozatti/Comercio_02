using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public class ConectaItensVendas
    {
        public string conec = @"Data Source=JUN0684686W11-1\BDSENAC;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        //public string conec = @"Data Source=MarcosCozatti\SQLEXPRESS;
        //                      Initial Catalog=BDComercioTi46;
        //                      Persist Security Info=True;
        //                      User ID=sa;Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;




        //Replica tabelas

        //MestreVendas
        public int id_ItensVendas { get; set; }
        public int id_MestreVendas { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }


        //CRUD CADCLI
        public void CadItensVendas()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "INSERT INTO ItensVenda (id_MestreVendas, Quantidade, ValorTotal) " +
                "VALUES (@id_MestreVendas, @Quantidade,@ValorTotal)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id_MestreVendas", id_MestreVendas);
            cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@ValorTotal", ValorTotal);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item de vendas adicionado!");
            con.Close();

        }



    




        public DataTable AtualizaGride(DataTable x,int idMestreVendas)
        {
            string strSql;
            strSql = "SELECT * FROM ItensVenda where id_MestreVendas = " + idMestreVendas;

            con = new SqlConnection(conec);
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return x;

        }


        int idOutraTabela = 0;


        public int PegaUltimoIdMestreVendas()
        {
            int idOutraTabela = 0;
            string connectionString = @"Data Source=JUN0684686W11-1\BDSENAC; " +
                                      "Initial Catalog=BDComercioTi46; " +
                                      "Persist Security Info=True; " +
                                      "User ID=senaclivre;Password=senaclivre";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 id_MestreVendas FROM MestreVendas ORDER BY id_MestreVendas DESC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    idOutraTabela = reader.GetInt32(0);
                }

                reader.Close();
            }

            return idOutraTabela;
        }




    }
}
