using SchoolMVC.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SchoolMVC.Business.Models;

public class TurmasModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo deve ser preenchido")]
    [Range(1,3)]
    public char Serie {  get; set; }

    public decimal Media { get; set; }

}
