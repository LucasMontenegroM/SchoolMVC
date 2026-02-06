using SchoolMVC.Domain.Enums;

namespace SchoolMVC.Domain.Entities;

public class AlunosEntity
{
    public int Id { get; private set; }

    public int Turma_Id { get; protected set; }

    public string Nome {  get; protected set; }

    public DateOnly DataNascimento {  get; protected set; }

    public decimal Media {  get; protected set; }

    public GeneroEnum Genero { get; protected set; }

    public AlunosEntity()
    {
        
    }

    public AlunosEntity(int turma, string nome, DateOnly data, decimal media, GeneroEnum genero)
    {
        Turma_Id = turma;
        Nome = nome;
        DataNascimento = data;
        Media = media;
        Genero = genero;
    }
}
