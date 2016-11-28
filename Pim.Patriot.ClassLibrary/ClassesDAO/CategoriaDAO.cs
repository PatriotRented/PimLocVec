﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim.Patriot.DataAccess.ClassesDAO
{
    public class CategoriaDAO
    {
        SqlConnection conexao;

        /// <summary>
        /// Retorna um data table com o codigo e o nome da categoria
        /// </summary>
        /// <returns></returns>
        public DataTable listaCat()
        {
            try
            {
                ConnectionFactory conn = new ConnectionFactory();
                conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = @"select CONCAT(codCat,' -  ',nomeCat) as mostraCat from Categoria;";
                DataTable dt = new DataTable();
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conexao.Close();

                return dt;
            }
            catch(SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    String erroMessages;
                    erroMessages = ("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                    MessageBox.Show(erroMessages);
                }
                throw ex;
            }
            

        }

        public string pegaCat(string _placa)
        {
            try
            {
                string ret;
                ConnectionFactory conn = new ConnectionFactory();
                SqlConnection conexao = new SqlConnection(conn.pegaConexao("connSQL"));

                SqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText =
                    @"select nomeCat from Categoria cat 
                        inner join Veiculo vec on (cat.codCat = vec.codCat) 
                        and placa = @placa";

                cmd.Parameters.AddWithValue("@placa",_placa);
                conexao.Open();

                ret = Convert.ToString(cmd.ExecuteScalar());

                conexao.Close();
                return ret;
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    String erroMessages;
                    erroMessages = ("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                    MessageBox.Show(erroMessages);
                }
                throw ex;
            }


        }
    }
}
