using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers.Client;

public class AccountController : Controller
{
    public IActionResult Dashboard()
    {
        return View("~/Views/Client/Account/Dashboard.cshtml");
    }
    public IActionResult Orders()
    {
        return View("~/Views/Client/Account/Orders.cshtml");
    }

    public IActionResult Addresses()
    {
        return View("~/Views/Client/Account/Addresses.cshtml");
    }

    public IActionResult AccountDetails()
    {
        return View("~/Views/Client/Account/AccountDetails.cshtml");
    }

    public IActionResult Logout()
    {
        //logic

        return RedirectToAction("index", "home");
    }

}
