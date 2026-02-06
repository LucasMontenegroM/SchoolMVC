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
        TurmasEntity newTurmaEntity = new TurmasEntity(turma.Serie);

        if (newTurmaEntity != null)
        {
            _turmaRepository.Create(newTurmaEntity);

            await _turmaRepository.Commit();

            return true;
        }

        return false;
    }

    public async Task<List<TurmasModel>> ListAll()
    {
        var turmasEntityList = await _turmaRepository.ListAll();

        List<TurmasModel> turmasModelList = [];

        foreach(var entity in turmasEntityList)
        {
            var x = new TurmasModel().Map(entity);

            turmasModelList.Add(x);            
        }
        return turmasModelList;
    } 

    public async Task<TurmasModel> GetById(int id)
    {
        var turmaEntity = await _turmaRepository.GetById(id);

        if (turmaEntity != null)
        {
            var turmaModel = new TurmasModel();

            turmaModel.Map(turmaEntity);

            return turmaModel;
        }

        return null;
    }

    public async Task<bool> Update(TurmasModel turmaModel)
    {
        if(turmaModel != null)
        {
            var turmaEntity = await _turmaRepository.GetById(turmaModel.Id);

            if(turmaEntity != null)
            {
                turmaEntity.UpdateSerie(turmaEntity.Serie);

                await _turmaRepository.Commit();

                return true;                
            }

            return false;
        }

        return false;
    }

    public async Task<bool> Delete(TurmasModel turmaModel)
    {
        if(turmaModel != null)
        {
        var turmaEntity = await _turmaRepository.GetById(turmaModel.Id);

            if (turmaEntity != null)
            {
                _turmaRepository.Delete(turmaEntity);

                await _turmaRepository.Commit();

                return true;
            }

            return false;
        }

        
        return false;
    }

}
