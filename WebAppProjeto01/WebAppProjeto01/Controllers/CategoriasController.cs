using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
        new Categoria() { CategoriaId = 1, Nome = "Notebooks"},
        new Categoria() { CategoriaId = 2, Nome = "Monitores"},
        new Categoria() { CategoriaId = 3, Nome = "Impressoras"},
        new Categoria() { CategoriaId = 4, Nome = "Mouses"},
        new Categoria() { CategoriaId = 5, Nome = "Desktops"}
        };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaId = categorias.Select(m => m.CategoriaId).Max() + 1;
            return RedirectToAction("Index");

            // try
            //{
                // TODO: Add insert logic here

                //return RedirectToAction("Index");
            //}
            //catch
            //{
                //return View();
            //}
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            categorias.Remove(
                categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
            categorias.Add(categoria);
            return RedirectToAction("Index");
            //try
            //{
            // TODO: Add update logic here

            //return RedirectToAction("Index");
            //}
            //catch
            //{
            //return View();
            //}
        }

        // GET: Categorias/Details/5
        public ActionResult Details(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categoria categoria)
        {
            categorias.Remove(
                categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
            return RedirectToAction("Index");
            //try
            //{
            // TODO: Add delete logic here

            //return RedirectToAction("Index");
            //}
            //catch
            //{
            //return View();
            //}
        }
    }
}
