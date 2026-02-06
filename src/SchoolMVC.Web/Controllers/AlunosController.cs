using Microsoft.AspNetCore.Mvc;
using SchoolMVC.Business.Interfaces;
using SchoolMVC.Business.Models;
using SchoolMVC.Business.Services;

namespace SchoolMVC.Web.Controllers;

public class AlunosController : Controller
{

    private readonly IAlunosService _alunosService;
    private readonly ITurmasService _turmasService;

    public AlunosController(IAlunosService alunosService, ITurmasService turmasService)
    {
        _alunosService = alunosService;
        _turmasService = turmasService;
    }

    public async Task<IActionResult> Index(int turma_Id)
    {
        var alunosModelList = await _alunosService.ListAll(turma_Id);

        return View(alunosModelList);
    }

    [HttpGet]
    public async Task<IActionResult> Create(int turma_Id)
    {
        var turmaModel = await _turmasService.GetById(turma_Id);

        if (turmaModel != null)
        {
            return View();
        }

        return NotFound();
    }

    [HttpPost]

    public async Task<IActionResult> Create(AlunosModel alunoModel)
    {
        var ableToCreate = await _alunosService.Create(alunoModel);

        if (ableToCreate != null) 
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]

    public async Task<IActionResult> UpdateMedia(int id)
    {
        var alunoModel = await _alunosService.GetAluno(id);

        if (alunoModel != null)
        {
            return View(alunoModel);
        }
        return NotFound();
    }

    [HttpPost]

    public async Task<IActionResult> UpdateMedia(int id)
    {
        var alunoModel = await _alunosService.GetAluno(id);

        var turmaModel = await _turmasService.GetById(alunoModel.Turma_Id);

        var ableToUpdate = await _alunosService.Update(alunoModel, turmaModel);
    }

}
