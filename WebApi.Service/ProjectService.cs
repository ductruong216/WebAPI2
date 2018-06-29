using System.Collections.Generic;
using System.Linq;
using WebApi.Domain.Entities;
using WebApi.Domain.Services;

namespace WebApi.Service
{
    public class ProjectService : BaseService<Project>, IProjectService
    {
        public IList<Project> GetActiveProject(int userID)
        {
           return  GetProjectList().Where(x => x.UserID == userID && x.StatusID == 1).ToList();
        }
        public IList<Project> GetClosedProject(int UserID)
        {
            return GetProjectList().Where(x => x.UserID == UserID && x.StatusID == 2).ToList();
        }

        public IList<Project> GetProjectList()
        {
            return GetList();
        }

    }
}
