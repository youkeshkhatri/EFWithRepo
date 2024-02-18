using EFWithRepo.Model;
using EFWithRepo.Repo;
using EFWithRepo.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWithRepo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _repo;

        public ProductController()
        {
            _repo = new ProductRepo();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetById(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                _repo.Add(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetById(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                _repo.Update(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repo.GetById(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _repo.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
