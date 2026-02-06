using SchoolMVC.Domain.Entities;
using SchoolMVC.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolMVC.Business.Models;

public class AlunosModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Insira a turma")]

    public int TurmaId { get; set; }

    [Required(ErrorMessage = "Nome deve ser preenchido")]

    public string Nome { get; set; }

    [Required(ErrorMessage = "Escolha uma data de nascimento")]

    public DateOnly DataNascimento { get; set; }

    [Required(ErrorMessage = "Qual foi a nota média desse aluno(a)?")]
    [Range(0,10)]

    public decimal Media { get; set; }

    [Required(ErrorMessage = "Selecione o Genero do(a) aluno(a)")]

    public GeneroEnum Genero { get; set; }

    public AlunosModel(AlunosEntity alunosEntity)
    {
        Id = alunosEntity.Id;
        DataNascimento = alunosEntity.DataNascimento;
        Genero = alunosEntity.Genero;
        Media = alunosEntity.Media;
        Nome = alunosEntity.Nome;
        TurmaId = alunosEntity.TurmaId;
    }
}

