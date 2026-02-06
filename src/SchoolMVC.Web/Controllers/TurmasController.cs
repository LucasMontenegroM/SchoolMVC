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

    public async Task<IActionResult> Index()
    {
        var turmas = await _turmasService.ListAll();

        return View(turmas);
    }

    [HttpGet]

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Create(TurmasModel turma)
    {
        var AbleTocreate = await _turmasService.Create(turma);

        if (AbleTocreate)
        {
            return RedirectToAction("Index");
        }

        return View();

    }

    [HttpGet]

    public async Task<IActionResult> Update(int id)
    {
        var turma = _turmasService.GetById(id);

        if (turma != null)
        {
            return View(turma);
        }

        return NotFound();

    }

    [HttpPost]
    public async Task<IActionResult> Update(TurmasModel turma)
    {
       var ableToUpdate = await _turmasService.Update(turma);

        if (ableToUpdate)
        {
            return RedirectToAction("Index");
        }

        return View(turma);
    }

    [HttpGet]

    public async Task<IActionResult> Delete(int id)
    {
        var turmaModel = await _turmasService.GetById(id);

        if (turmaModel != null)
        {
            return View(turmaModel);
        }

        return NotFound();
    }

    [HttpPost]

    public async Task<IActionResult> Delete(TurmasModel turmaModel)
    {
        var AbleToDelete = await _turmasService.Delete(turmaModel);

        if (AbleToDelete)
        {
            return RedirectToAction("Index");
        }
        return View(turmaModel);
    }
}
