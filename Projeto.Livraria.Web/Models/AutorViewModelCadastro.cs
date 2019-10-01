using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Livraria.Web.Models
{
    public class AutorViewModelCadastro
    {
        [MinLength(3, ErrorMessage = "O nome não pode ter mais de {1} caracteres")]
        [MaxLength(50, ErrorMessage = "O nome não pode ter mais de {1} caracteres")]
        [Required(ErrorMessage = "Por favor informe o nome do autor.")]
        [Display(Name = "Informe o nome do autor:")]
        public string NomeAutor { get; set; }
    }
}