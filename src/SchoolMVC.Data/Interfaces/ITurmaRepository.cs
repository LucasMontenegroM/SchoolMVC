using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Data.Interfaces;

public interface ITurmaRepository
{
    public void Create(TurmasEntity turma);

    public Task<List<TurmasEntity>> ListAll();

    public Task<TurmasEntity> GetById(int id);
    public Task Commit();
}
