using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Business.Interfaces;
using SchoolMVC.Business.Models;

namespace SchoolMVC.Web.Controllers;

public class TurmasController : Controller
{

    private readonly ITurmasService _turmasService;

    public TurmasController(ITurmasService turmasService)
    {
        _turmasService = turmasService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Create(TurmasModel turma)
    {
        var created = await _turmasService.Create(turma);

        //if statement

        return RedirectToAction("Index");
    }

}
