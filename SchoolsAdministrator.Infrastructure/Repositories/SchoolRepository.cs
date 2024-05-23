using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Core.Interfaces.Repositories;

namespace SchoolsAdministrator.Infrastructure.Repositories;

public class SchoolRepository : BaseRepository<School>, ISchoolRepository
{
    public SchoolRepository(AppDbContext context) : base(context)
    {

    }
}