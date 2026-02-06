namespace SchoolMVC.Domain.Entities;

public class TurmasEntity
{
    public int Id { get; private set; }

    public char Serie { get; protected set; }

    public decimal Media { get; protected set; }

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

    public decimal CalculaMedia(List<AlunosEntity> alunos)
    {

        decimal notaTotal = 0;

        var quantidadeDeAlunosSomados = 0;

           foreach (var aluno in alunos)
           {
              notaTotal += aluno.Media;

              quantidadeDeAlunosSomados++;
           }
        
        return notaTotal / quantidadeDeAlunosSomados;
    }

}
