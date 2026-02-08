using Microsoft.EntityFrameworkCore;
using SchoolMVC.Data.Context;
using SchoolMVC.Data.Interfaces;
using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Data.Repositories;

public class TurmaRepository : ITurmaRepository
{

    private readonly SchoolContext _db;

    public TurmaRepository(SchoolContext db)
    {
        _db = db;
    }

    public void Create(TurmasEntity turma)
    {
         _db.Turmas.Add(turma);
    }

    public async Task<List<TurmasEntity>> ListAll()
    {
        return await _db.Turmas.AsNoTracking().ToListAsync();
    } 

    public async Task Commit()
    {
        await _db.SaveChangesAsync();
    }

    public async Task<TurmasEntity> GetById(int id)
    {
        return await _db.Turmas.FirstOrDefaultAsync(t => t.Id == id);
    }

    public void Delete(TurmasEntity turmaEntity)
    {
        _db.Turmas.Remove(turmaEntity);
    }
}
