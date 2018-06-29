using System.Collections.Generic;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services
{
    public interface ITaskService : IBaseService<Task>
    {
        IList<Task> GetActiveTask(int projectID, int userID);
        IList<Task> GetResolvedTask(int projectID, int userID);
    }
}
