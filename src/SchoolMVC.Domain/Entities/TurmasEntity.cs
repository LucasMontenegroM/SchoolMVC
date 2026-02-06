namespace SchoolMVC.Domain.Entities;

public class TurmasEntity
{
    public int Id { get; private set; }
    public char Serie { get; protected set; }
    public decimal Media { get; protected set; }
    public List<AlunosEntity> Alunos {  get; protected set; }

    public TurmasEntity()
    {
        
    }

    public TurmasEntity(char serie)
    {
        Serie = serie;
        Media = 0;
    }

    public void UpdateSerie(char serie)
    {
        Serie = serie;
    }

    public void CalculaNovaMedia(List<AlunosEntity> alunos)
    {
        decimal notaTotal = 0;

        foreach (var aluno in alunos)
        {
            notaTotal += aluno.Media;
        }
        
        Media = notaTotal / alunos.Count();
    }
}
