using Backend.Financeiro.Infra.Data.Repositories.Systems.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.MVC.Controllers
{
    public class FinanceSystemUsersController : Controller
    {
        private readonly FinanceSystemUserRepository _financeSystemUserRepository = new FinanceSystemUserRepository();  

        // GET: FinanceSystemUsersController
        public async Task<IActionResult> Index()
        {
            return View( await _financeSystemUserRepository.GetAll());
        }

        // GET: FinanceSystemUsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FinanceSystemUsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinanceSystemUsersController/Create
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

        // GET: FinanceSystemUsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinanceSystemUsersController/Edit/5
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

        // GET: FinanceSystemUsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FinanceSystemUsersController/Delete/5
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
