using WebApi.Domain.Entities;

namespace WebApi.Repository
{
    public class ProjectRepository : MainRepository<Project>
    {
        public ProjectRepository(ProjectManagerEntities context) : base(context)
        {

        }
    }
}
