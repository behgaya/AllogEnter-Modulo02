namespace Univali.Api.Models;

public class PublisherWithCoursesWithAuthorsDto
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    // Pode ser CPF ou CNPJ
    // Vamos utilizar CNPJ para ficar diferente.
    public string CNPJ {get; set;} = string.Empty;
    public List<CourseWithAuthorsDto> Courses {get; set;} = new();
}