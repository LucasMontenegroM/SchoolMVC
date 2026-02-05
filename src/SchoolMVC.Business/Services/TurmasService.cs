using SchoolMVC.Business.Interfaces;
using SchoolMVC.Business.Models;
using SchoolMVC.Data.Interfaces;
using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Business.Services;

public class TurmasService : ITurmasService
{

    private readonly ITurmaRepository _turmaRepository;

    public TurmasService(ITurmaRepository turmaRepository)
    {
        _turmaRepository = turmaRepository;
    }
    public async Task<bool> Create(TurmasModel turma)
    {
        var newTurmaEntity = new TurmasEntity(turma.Serie);

        if (newTurmaEntity != null) 
        {
            await _turmaRepository.Commit();
            return true;
        }
        
        return false;
    }
}
