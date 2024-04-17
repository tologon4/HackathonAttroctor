using Microsoft.AspNetCore.Mvc;

namespace hacaton.Controllers;

public class WorkController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
}