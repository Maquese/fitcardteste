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
        public ActionResult Details(int id)
        {
            return View();
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
                return View();
            }
        }

        // GET: Estabelecimento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estabelecimento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estabelecimento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estabelecimento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private void CarregarCategorias()
        {
            ViewBag.Categorias = new SelectList(_CategoriaApp.Listar(),"Id","Nome");
        }
    }
}
