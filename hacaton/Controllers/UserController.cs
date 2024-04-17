using Microsoft.AspNetCore.Mvc;

namespace hacaton.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}