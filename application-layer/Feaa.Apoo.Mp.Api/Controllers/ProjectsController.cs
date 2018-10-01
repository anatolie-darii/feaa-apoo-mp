using System;
using System.Collections.Generic;

using Feaa.Apoo.Mp.Domain.Services;
using Feaa.Apoo.Mp.Domain.ValueObjects;

using Microsoft.AspNetCore.Mvc;

namespace Feaa.Apoo.Mp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ProjectsController : ControllerBase
    {
        private ProjectService projectService;

        public ProjectsController()
        {
            this.projectService = new ProjectService();
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProjectListItemModel>> Get() => new List<ProjectListItemModel>();

        [HttpGet("{id}")]
        public ActionResult<EditProjectModel> Get(Guid id) => new EditProjectModel();

        [HttpPost]
        public void Post([FromBody] AddProjectModel value) { }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] EditProjectModel value) { }

        [HttpDelete("{id}")]
        public void Delete(Guid id) { }
    }
}