using Microsoft.AspNetCore.Mvc;
using pitpm_pr1.Models;
using pitpm_pr1.Controllers;

namespace rpm_1pr.Controllers
{
    public class RegistratioController : Controller
    {
        public IActionResult Registr() //contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Registration registration)
        {
            if (ModelState.IsValid) //проверяем верные ли данные
            {
                return Redirect("/"); //переадр на глав страницу
            }

            return View("Registr"); // возвращаем шаблон Registr
        }
    }
}
