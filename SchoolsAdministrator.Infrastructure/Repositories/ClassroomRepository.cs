using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Core.Interfaces.Repositories;

namespace SchoolsAdministrator.Infrastructure.Repositories;
public class ClassroomRepository : BaseRepository<Classroom>, IClassroomRepository
{
    public ClassroomRepository(AppDbContext context) : base(context)
    {

    }
}