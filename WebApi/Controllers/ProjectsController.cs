using System.Collections.Generic;
using System.Web.Http;
using WebApi.Domain.Entities;
using WebApi.Domain.Services;
using WebApi.Service;

namespace WebApi.Controllers
{
    [RoutePrefix("Projects")]
    public class ProjectsController : ApiController
    {
        private IProjectService _projectService;
        public ProjectsController()
        {
            _projectService = new ProjectService();
        }

        [Route("Active/{userId}")]
        public IEnumerable<Project> GetActiveProjects(int userId)
        {
            return _projectService.GetActiveProject(userId);
        }

        [Route("Closed/{userId}")]
        public IEnumerable<Project> GetClosedProjects(int userId)
        {
            return _projectService.GetClosedProject(userId);
        }
    }
}
