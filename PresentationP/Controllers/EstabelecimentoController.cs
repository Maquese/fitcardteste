using ApplicationContract.Contracts;
using ApplicationContract.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationP.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private readonly IEstabelecimentoApp _EstabelecimentoApp;
        private readonly ICategoriaApp _CategoriaApp;

        public EstabelecimentoController(IEstabelecimentoApp estabelecimentoApp, ICategoriaApp categoriaApp)
        {
            _EstabelecimentoApp = estabelecimentoApp;
            _CategoriaApp = categoriaApp;
        }
        // GET: Estabelecimento
        public ActionResult Index()
        {
            return View(_EstabelecimentoApp.Listar());
        }

        // GET: Estabelecimento/Details/5
        public ActionResult Details(Guid id)
        {
           var estabelecimento = _EstabelecimentoApp.Buscar(id);
            return View(estabelecimento);
        }

        // GET: Estabelecimento/Create
        public ActionResult Create()
        {
            CarregarCategorias();
            return View();
        }

        // POST: Estabelecimento/Create
        [HttpPost]
        public ActionResult Create(EstabelecimentoDTO estabelecimento)
        {
            try
            {
                // TODO: Add insert logic here
                _EstabelecimentoApp.Novo(estabelecimento);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {

                ViewBag.ErrorException = e.Message;
                CarregarCategorias();
                return View(estabelecimento);
            }
        }

        // GET: Estabelecimento/Edit/5
        public ActionResult Edit(Guid id)
        {
           var estabelecimento =  _EstabelecimentoApp.Buscar(id);

            CarregarCategorias(estabelecimento.Categoria.Id.ToString());
            return View(estabelecimento);
        }

        // POST: Estabelecimento/Edit/5
        [HttpPost]
        public ActionResult Edit(EstabelecimentoDTO estabelecimento,Guid asdas)
        {
            try
            {
                estabelecimento.IdCategoria = asdas;
                // TODO: Add update logic here
                _EstabelecimentoApp.Editar(estabelecimento);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.ErrorException = e.Message;
                CarregarCategorias(asdas.ToString());
                return View(estabelecimento);
            }
        }

        // GET: Estabelecimento/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_EstabelecimentoApp.Buscar(id));
        }

        // POST: Estabelecimento/Delete/5
        [HttpPost]
        public ActionResult Delete(EstabelecimentoDTO estabelecimento)
        {
            try
            {
                _EstabelecimentoApp.Excluir(estabelecimento.Id);

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.ExceptionError = e.Message;
                return View();
            }
        }

        private void CarregarCategorias(string id = null)
        {

            ViewBag.Lista = new SelectList(_CategoriaApp.Listar().OrderBy(x => x.Nome),"Id","Nome",id);
        }
    }
}
