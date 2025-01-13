using EjemploApp.ConsumeAPI;
using EjemploApp.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploApp.WebMVC.Controllers
{
    public class AutoresController : Controller
    {
        private string apiUrl;

        public AutoresController(IConfiguration configuration)
        {
            apiUrl = configuration["ApiURL"] + "/Autores";
        }

        // GET: AutoresController
        public ActionResult Index()
        {
            var data = Crud<Autor>.Read_All(apiUrl);
            return View(data);
        }

        // GET: AutoresController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Autor>.Read_ById(apiUrl, id);
            return View(data);
        }

        // GET: AutoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Autor data)
        {
            try
            {
                data = Crud<Autor>.Create(apiUrl, data);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: AutoresController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Autor>.Read_ById(apiUrl, id);
            return View(data);
        }

        // POST: AutoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Autor data)
        {
            try
            {
                Crud<Autor>.Update(apiUrl, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: AutoresController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Crud<Autor>.Read_ById(apiUrl, id);
            return View(data);
        }

        // POST: AutoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Autor data)
        {
            try
            {
                Crud<Autor>.Delete(apiUrl, id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}
