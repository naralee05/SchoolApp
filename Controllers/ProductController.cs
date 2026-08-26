using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;

namespace SchoolApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly SchoolDbContext _context;
        public ProductController(SchoolDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}