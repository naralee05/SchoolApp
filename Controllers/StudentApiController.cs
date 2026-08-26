using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentApiController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public StudentApiController(SchoolDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();

            if (students == null || students.Count == 0)
            {
                return NotFound("រកមិនឃើញទិន្នន័យសិស្សឡើយ។"); // "No students found." in Khmer
            }
            return Ok(students);
        }
    }
}