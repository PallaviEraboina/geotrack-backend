using Microsoft.AspNetCore.Mvc;
using GeoTrack.Api.Models;

namespace GeoTrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private static readonly List<Project> projects = new()
        {
            new Project
            {
                Id = 1,
                Name = "West Gate Tunnel",
                Location = "Melbourne",
                Latitude = -37.8136,
                Longitude = 144.9631,
                Status = "In Progress"
            },
            new Project
            {
                Id = 2,
                Name = "Sydney Metro Expansion",
                Location = "Sydney",
                Latitude = -33.8688,
                Longitude = 151.2093,
                Status = "Pending"
            },
            new Project
            {
                Id = 3,
                Name = "Brisbane Road Upgrade",
                Location = "Brisbane",
                Latitude = -27.4698,
                Longitude = 153.0251,
                Status = "Completed"
            }
        };

        [HttpGet]
        public ActionResult<List<Project>> GetAll()
        {
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public ActionResult<Project> GetById(int id)
        {
            var project = projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
                return NotFound();

            return Ok(project);
        }

    }
}