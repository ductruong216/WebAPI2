using System.Collections.Generic;
using System.Linq;
using WebApi.Domain.Entities;
using WebApi.Domain.Services;

namespace WebApi.Service
{
    public class TaskService : BaseService<Task>, ITaskService
    {
        public IList<Task> GetTaskList()
        {
            return GetList();
        }

        public IList<Task> GetActiveTask(int projectID, int userID)
        {
            return GetList().Where(x => x.ProjectID == projectID && x.UserID == userID && x.StatusID == 1).ToList();
        }

        public IList<Task> GetResolvedTask(int projectID, int userID)
        {
            return GetList().Where(x => x.ProjectID == projectID && x.UserID == userID && x.StatusID == 3).ToList();
        }
    }
}
