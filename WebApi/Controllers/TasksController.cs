using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Domain.Entities;
using WebApi.Domain.Services;
using WebApi.Service;

namespace WebApi.Controllers
{
    [RoutePrefix("Tasks")]
    public class TasksController : ApiController
    {
        private ITaskService _taskService;
        public TasksController()
        {
            _taskService = new TaskService();
        }
        [Route("Active/{projectId}/{userId}")]
        public IEnumerable<Task> GetActiveTasks(int projectId, int userId)
        {
            return _taskService.GetActiveTask(projectId, userId);
        }

        [Route("Resolved/{userId}")]
        public IEnumerable<Task> GetResolvedTasks(int projectId, int userId)
        {
            return _taskService.GetResolvedTask(projectId, userId);
        }
    }
}
