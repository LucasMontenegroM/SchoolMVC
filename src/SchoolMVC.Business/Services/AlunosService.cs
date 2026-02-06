using SchoolMVC.Business.Interfaces;
using SchoolMVC.Business.Models;
using SchoolMVC.Data.Interfaces;
using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Business.Services;

public class AlunosService : IAlunosService
{
    private readonly IAlunoRepository _alunosRepository;

    public AlunosService(IAlunoRepository alunoRepository)
    {
        _alunosRepository = alunoRepository;
    }

    public async Task<List<AlunosModel>> ListAll(int turmaId)
    {
        if(turmaId > 0) 
        {
            var entityList = await _alunosRepository.ListAll(turmaId);

            if (entityList != null)
            {
                List<AlunosModel> modelList = [];

                foreach (var entity in entityList)
                {
                    var x = new AlunosModel(entity);
                    modelList.Add(x);
                }

                return modelList;
            }
        }

        return null;
    }

    public async Task<AlunosModel> GetAluno(int id)
    {
        var alunoEntity = await _alunosRepository.GetById(id);

        if (alunoEntity != null)
        {
            var alunoModel = new AlunosModel(alunoEntity);

            return alunoModel;
        }

        return null;
    }

    public async Task<bool> Create(AlunosModel alunoModel, TurmasModel turmaModel)
    {
        if(alunoModel != null)
        {
            var alunoEntity = new AlunosEntity(
                alunoModel.Turma_Id,
                alunoModel.Nome,
                alunoModel.DataNascimento,
                alunoModel.Media,
                alunoModel.Genero
            );

            
            await _alunosRepository.Commit();

            return true;
        }

        return false;
    }

}
