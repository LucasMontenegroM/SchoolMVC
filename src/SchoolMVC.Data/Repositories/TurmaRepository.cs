using SchoolMVC.Data.Context;
using SchoolMVC.Data.Interfaces;

namespace SchoolMVC.Data.Repositories;

public class TurmaRepository : ITurmaRepository
{

    private readonly SchoolContext _db;
    public TurmaRepository(SchoolContext db)
    {
        _db = db;
    }

    public async Task Commit()
    {
        await _db.SaveChangesAsync();
    }
}
