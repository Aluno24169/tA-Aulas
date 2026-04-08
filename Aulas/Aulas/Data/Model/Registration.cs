using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model
{
    /// <summary>
    /// Classe do relacionamento entre alunos e disciplinas
    /// </summary>
    /// 
    [PrimaryKey(nameof(StudentFK),nameof(CourseFK))] // PK composta (EF Core >=7)
    public class Registration
    {
        public DateTime RegistrationDate { get; set; }

        //FK para Student
        //[Key, Column(Order = 1)] --> Válido para EF <=6
        public int StudentFK { get; set; }
        public Student Student { get; set; } = null!;

        //FK para Course
        //[Key, Column(Order = 2)] --> Válido para EF <=6
        public int CourseFK { get; set; }
        public Course Course { get; set; } = null!;
    }
}
