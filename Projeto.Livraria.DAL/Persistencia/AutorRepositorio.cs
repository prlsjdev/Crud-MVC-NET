using Projeto.Livraria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Livraria.DAL.Persistencia
{
    public class AutorRepositorio : Conexao
    {
        public void Inserir(Autor a)
        {
            AbrirConexao();

            string query = "insert into Autor(Nome) values(@Nome)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", a.Nome);
            cmd.ExecuteNonQuery();

            FecharConexao();
        }


        public void Atualizar(Autor a)
        {
            AbrirConexao();
            string query = "update Autor set Nome = @Nome where IdAutor = @IdAutor";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdAutor", a.IdAutor);
            cmd.Parameters.AddWithValue("@Nome", a.Nome);

            cmd.ExecuteNonQuery();

            FecharConexao();
        }

        public void Excluir(Autor a)
        {
            AbrirConexao();
            string query = "delete from Autor where IdAutor = @IdAutor";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdAutor", a.IdAutor);
            cmd.ExecuteNonQuery();

            FecharConexao();
        }

        public List<Autor> ListarTodos()
        {
            AbrirConexao();
            string query = "select * from Autor";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            List<Autor> lista = new List<Autor>();

            while (dr.Read())
            {
                Autor a = new Autor();
                a.IdAutor = Convert.ToInt32(dr["IdAutor"]);
                a.Nome = Convert.ToString(dr["Nome"]);

                lista.Add(a);
            }



            FecharConexao();
            return lista;
        }

        public Autor ObterPorId(int idAutor)
        {
            AbrirConexao();

            string query = "select * from Autor where IdAutor = @IdAutor";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdAutor", idAutor);
            dr = cmd.ExecuteReader();

            Autor a = null; //sem espaço de memória..

            if (dr.Read()) //se algum registro foi encontrado..
            {
                a = new Autor(); //criando espaço de memória..
                a.IdAutor = Convert.ToInt32(dr["IdAutor"]);
                a.Nome = Convert.ToString(dr["Nome"]);
            }

            FecharConexao();
            return a; //retornando objeto..
        }


    }
}
