using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Livraria.Entidades
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; } //Associacao "autor tem muitos livros".

        public Autor()
        {
        }

        public Autor(int idAutor, string nome)
        {
            IdAutor = idAutor;
            Nome = nome;
        }

    }
}
