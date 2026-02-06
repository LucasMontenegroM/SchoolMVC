using SchoolMVC.Business.Models;
using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Business.Interfaces;

public interface ITurmasService
{
    public Task<bool> Create(TurmasModel turma);

    public Task<List<TurmasModel>> ListAll();

    public Task<TurmasModel> GetById(int id);

    public Task<bool> Update(TurmasModel turmaModel);

    public Task<bool> Delete(TurmasModel turmaModel);
}
