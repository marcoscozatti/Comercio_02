﻿using System;
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
    class ConectaCli
    {

        public string conec = @"Data Source=JUN0684686W11-1\BDSENAC;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas
        public int id { get; set; }
        public string Cliente { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime dataCadCli { get; set; }


        //CRUD CADCLI
        public void InserirCadcli()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "INSERT INTO CadClientes (Cliente, Sobrenome, Telefone, Email, dataCadCli) " +
                "VALUES (@Cliente, @Sobrenome, @Telefone, @Email, @dataCadCli)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@dataCadCli", dataCadCli);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro adicionado!");
            con.Close();

        }

        public void AlterarCadcli()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "update CadClientes set Cliente = @Cliente, Sobrenome = @Sobrenome, " +
                "Telefone=@Telefone, Email=@Email, dataCadCli=@dataCadCli where id = @id";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@dataCadCli", dataCadCli);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Alterado!");
            con.Close();
        }


        public void ExcluirCadcli()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "DELETE FROM CadClientes WHERE id=@id";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Excluido!");
            con.Close();
        }


        public DataTable AtualizaGride(DataTable x)
        {
            string strSql;
            strSql = "SELECT * FROM CadClientes";

            con = new SqlConnection(conec);
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return x;

        }

        public DataTable PesquisaNome(DataTable x, string txtPes)
        {
            string strSql;
            strSql = "SELECT * FROM CadClientes WHERE cliente LIKE '%" + txtPes + "%'";
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
