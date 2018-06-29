using System.Collections.Generic;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services
{
    public interface IProjectService : IBaseService<Project>
    {
        IList<Project> GetActiveProject(int userID);
        IList<Project> GetClosedProject(int userID);
    }
}
