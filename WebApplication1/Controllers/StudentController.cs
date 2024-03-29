using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{


    public class StudentController : Controller
    {

        public ApplicationDBContext dbContext;
        public StudentController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Models.Entity.Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            return View();
        }
    }
}
