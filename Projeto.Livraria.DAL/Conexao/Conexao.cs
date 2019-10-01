using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto.Livraria.DAL
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;

        protected void AbrirConexao()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings
                ["dbbanco"].ConnectionString);

            con.Open();
        }

        protected void FecharConexao()
        {
            con.Close();
        }

    }
}
