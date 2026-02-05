using SchoolMVC.Business.Models;
using SchoolMVC.Domain.Entities;

namespace SchoolMVC.Business.Interfaces;

public interface ITurmasService
{
    public Task<bool> Create(TurmasModel turma);
}
