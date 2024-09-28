using System;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoBruno.Controllers;

public class CursoController : Controller
{
    public IActionResult Index ()
    {
        return View();
    }
}
