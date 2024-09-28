using System;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoBruno.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
