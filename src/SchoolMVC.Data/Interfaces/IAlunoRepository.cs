using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Data.Interfaces;

public interface IAlunoRepository
{
    public Task<List<AlunosEntity>> ListAll(int turmaId);

    public Task<AlunosEntity> GetById(int id);

    public Task Commit();
}
