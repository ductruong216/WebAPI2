using WebApi.Domain.Entities;

namespace WebApi.Repository
{
    public class TaskRepository : MainRepository<Task>
    {
        public TaskRepository(ProjectManagerEntities context) : base(context)
        {

        }
    }
}
