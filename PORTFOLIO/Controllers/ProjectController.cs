using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PORTFOLIO.Data;
using PORTFOLIO.Models;

namespace PORTFOLIO.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ProjectController(ApplicationDbContext applicationDbContext)
        {

            _dbContext = applicationDbContext;

        }
        public async Task<IActionResult> Project()
        {
            List<Project> _list = await _dbContext.ProjectList.ToListAsync();
            return View(_list);
        }
    }
}
