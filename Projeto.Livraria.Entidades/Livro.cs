using Projeto.Livraria.Entidades.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Livraria.Entidades
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Foto { get; set; }
        public Genero Genero { get; set; }
        public Autor Autor { get; set; }

        public Livro()
        {
        }

        public Livro(int idLivro, string titulo, string sinopse, string foto, Genero genero)
        {
            IdLivro = idLivro;
            Titulo = titulo;
            Sinopse = sinopse;
            Foto = foto;
            Genero = genero;
            
        }
    }
}
