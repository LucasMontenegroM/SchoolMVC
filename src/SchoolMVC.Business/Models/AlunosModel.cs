using SchoolMVC.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace SchoolMVC.Business.Models;

public class AlunosModel
{
    public int Id { get; private set; }

    [Required(ErrorMessage = "Insira a turma")]

    public int Turma_Id { get; protected set; }

    [Required(ErrorMessage = "Nome deve ser preenchido")]

    public string Nome { get; protected set; }

    [Required(ErrorMessage = "Escolha uma data de nascimento")]

    public DateOnly DataNascimento { get; protected set; }

    [Required(ErrorMessage = "Qual foi a nota média desse aluno(a)?")]
    [Range(0,10)]

    public decimal Media { get; protected set; }

    [Required(ErrorMessage = "Selecione o Genero do(a) aluno(a)")]

    public GeneroEnum Genero { get; protected set; }
}
