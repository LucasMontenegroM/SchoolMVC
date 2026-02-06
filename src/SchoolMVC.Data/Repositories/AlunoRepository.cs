using Microsoft.EntityFrameworkCore;
using SchoolMVC.Data.Context;
using SchoolMVC.Data.Interfaces;
using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Data.Repositories;

public class AlunoRepository : IAlunoRepository
{
    private readonly SchoolContext _db;

    public AlunoRepository(SchoolContext db)
    {
        _db = db;
    }

    public async Task<List<AlunosEntity>> ListAll(int turmaId)
    {
        return await _db.Alunos.AsNoTracking().Where(a => a.TurmaId == turmaId).ToListAsync();
    }

    public async Task<AlunosEntity> GetById(int id)
    {
        return await _db.Alunos.FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task Commit()
    {
        await _db.SaveChangesAsync();
    }

}
