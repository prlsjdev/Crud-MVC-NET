using Projeto.Livraria.DAL.Persistencia;
using Projeto.Livraria.Entidades;
using Projeto.Livraria.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Livraria.Web.Controllers
{
    public class AutorController : Controller
    {
        // GET: Autor/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(AutorViewModelCadastro model)
        {
            if (ModelState.IsValid) {
                try
                {
                    Autor a = new Autor();
                    a.Nome = model.NomeAutor;

                    AutorRepositorio rep = new AutorRepositorio();
                    rep.Inserir(a); //gravando..

                    ViewBag.Message = $"Autor {a.Nome}, cadastrado com sucesso";
                    ModelState.Clear(); //limpar todos os campos da model.

                }
                catch (Exception e)
                {

                    ViewBag.Message = e.Message;
                }
               

            }
            return View();
        }

        // GET: Autor/Consulta
        public ActionResult Consulta()
        {
            var lista = new List<AutorViewModelConsulta>();

            try
            {
                AutorRepositorio rep = new AutorRepositorio();
                foreach (Autor a in rep.ListarTodos())
                {
                    var model = new AutorViewModelConsulta();
                    model.IdAutor = a.IdAutor;
                    model.NomeAutor = a.Nome;

                    lista.Add(model);
                }
            }
            catch (Exception e)
            {

                ViewBag.Message = e.Message;
            }
            return View(lista);
        }
    }
}