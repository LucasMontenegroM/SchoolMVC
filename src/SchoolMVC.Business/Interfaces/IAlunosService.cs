using SchoolMVC.Business.Models;

namespace SchoolMVC.Business.Interfaces;

public interface IAlunosService
{
    public Task<List<AlunosModel>> ListAll(int turmaId);

    public Task<bool> Create(AlunosModel alunoModel);

    public Task<AlunosModel> GetAluno(int id);
}
