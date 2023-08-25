using Backend.Financeiro.Infra.Data.Repositories.Systems;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.MVC.Controllers
{
    public class FinanceSystemsController : Controller
    {
        private readonly FinanceSystemRepository _financeSystemRepository = new FinanceSystemRepository();
        // GET: FinanceSystems
        public ActionResult Index()
        {
            return View(_financeSystemRepository.GetAll());
        }

        // GET: FinanceSystems/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FinanceSystems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinanceSystems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FinanceSystems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinanceSystems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FinanceSystems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FinanceSystems/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
