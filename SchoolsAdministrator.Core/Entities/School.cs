using System.Collections.ObjectModel;

namespace SchoolsAdministrator.Core.Entities;

public class School
{
    public School()
    {
        Classrooms = new Collection<Classroom>();
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public ICollection<Classroom> Classrooms { get; set; }
}
