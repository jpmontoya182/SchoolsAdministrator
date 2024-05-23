using SchoolsAdministrator.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsAdministrator.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISchoolRepository SchoolRepository { get; }
        IClassroomRepository ClassroomRepository { get; }

        Task<int> CommitAsync();
    }
}
