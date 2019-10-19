using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Projeto.Livraria.Web.Models
{
    public class AutorViewModelEdicao
    {
        [Display(Name = "Código do Autor:")]
        public int IdAutor { get; set; }

        [Display(Name = "Nome do autor:")]
        [Required(ErrorMessage = "Favor digite o nome do autor.")]
        [MinLength(3, ErrorMessage = "Por favor informe no minimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Por favor informe no máximo {1} caracteres.")]
        public string NomeAutor { get; set; }

    }
}