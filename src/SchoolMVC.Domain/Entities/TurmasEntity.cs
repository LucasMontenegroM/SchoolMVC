namespace SchoolMVC.Domain.Entities;

public class TurmasEntity
{
    public int Id { get; private set; }

    public char Serie { get; protected set; }

    public decimal Media { get; protected set; }

    public TurmasEntity(char serie)
    {
        Serie = serie;
        Media = 0;
    }

    private decimal CalculaMedia(List<AlunosEntity> alunos)
    {

        decimal notaTotal = 0;

        var quantidadeDeAlunos = 0;

        foreach (var aluno in alunos)
        {
            notaTotal += aluno.Media;
            quantidadeDeAlunos++;
        }

        return notaTotal / quantidadeDeAlunos;
    }

}
