using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Learning_System_2._0.Models;
using System.Diagnostics;

namespace E_Learning_System_2._0.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ELearnDbContext _context;

        public StudentsController(ELearnDbContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var eLearnDbContext = _context.Students.Include(s => s.UsernameNavigation);
            return View(await eLearnDbContext.ToListAsync());
        }

        // GET: Students/ShowSingleCourse/5
        public async Task<IActionResult> GoForMachineLearning(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }            
            return View(student);
        }


        // GET: Students/GoForProgramming
        public async Task<IActionResult> GoForProgramming(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

        return View(student);

        }


        // GET: Students/ShowSingleCourse/5
        public async Task<IActionResult> GoForWebDevelop(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);

        }

        // GET: Students/ShowSingleCourse/5
        public async Task<IActionResult> Revision(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }
                   
        return View(student);

        }

        public async Task<IActionResult> HumanComputer(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }
        public async Task<IActionResult> HumanComputerTest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }
        public async Task<IActionResult> Software(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }
        public async Task<IActionResult> SoftwareTest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }

        public async Task<IActionResult> Database(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }

        public async Task<IActionResult> DatabaseTest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }

        public async Task<IActionResult> FrontEnd(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        public async Task<IActionResult> FrontEndTest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        public async Task<IActionResult> BackEnd(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }

        public async Task<IActionResult> BackEndTest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }
        public async Task<IActionResult> AI(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public async Task<IActionResult> AITest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }
        public async Task<IActionResult> Algorithm(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }

        public async Task<IActionResult> AlgorithmTest(string? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Username == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);

        }

    }
}
