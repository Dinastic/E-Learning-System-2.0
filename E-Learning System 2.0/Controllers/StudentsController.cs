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

            /*List<CourseHasStudent> elements = _context.CourseHasStudents
                .Where(x => x.RegistrationNumber == student.RegistrationNumber && x.GradeCourseStudent >= 0)
                .ToList();

            List<Course> courses = _context.Courses.ToList();

            var coursetitles = from x in elements
                               join y in courses on x.IdCourse equals y.IdCourse
                               where x.RegistrationNumber == student.RegistrationNumber
                               select new Grade
                               {
                                   IdCourse = y.IdCourse,
                                   CourseTitle = y.CourseTitle,
                                   RegistrationNumber = student.RegistrationNumber
                               };*/
            return View("");

        }


        // GET: Students/ShowSingleCourse/5
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

            /*List<CourseHasStudent> elements = _context.CourseHasStudents
                .Where(x => x.RegistrationNumber == student.RegistrationNumber && x.GradeCourseStudent >= 0)
                .ToList();

            List<Course> courses = _context.Courses.ToList();

            var coursetitles = from x in elements
                               join y in courses on x.IdCourse equals y.IdCourse
                               where x.RegistrationNumber == student.RegistrationNumber
                               select new Grade
                               {
                                   IdCourse = y.IdCourse,
                                   CourseTitle = y.CourseTitle,
                                   RegistrationNumber = student.RegistrationNumber
                               };*/
            return View("");

        }


        // GET: Students/ShowSingleCourse/5
        public async Task<IActionResult> GoForTeaching(string? id)
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

            /*List<CourseHasStudent> elements = _context.CourseHasStudents
                .Where(x => x.RegistrationNumber == student.RegistrationNumber && x.GradeCourseStudent >= 0)
                .ToList();

            List<Course> courses = _context.Courses.ToList();

            var coursetitles = from x in elements
                               join y in courses on x.IdCourse equals y.IdCourse
                               where x.RegistrationNumber == student.RegistrationNumber
                               select new Grade
                               {
                                   IdCourse = y.IdCourse,
                                   CourseTitle = y.CourseTitle,
                                   RegistrationNumber = student.RegistrationNumber
                               };*/
            return View("");

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

            /*List<CourseHasStudent> elements = _context.CourseHasStudents
                .Where(x => x.RegistrationNumber == student.RegistrationNumber && x.GradeCourseStudent >= 0)
                .ToList();

            List<Course> courses = _context.Courses.ToList();

            var coursetitles = from x in elements
                               join y in courses on x.IdCourse equals y.IdCourse
                               where x.RegistrationNumber == student.RegistrationNumber
                               select new Grade
                               {
                                   IdCourse = y.IdCourse,
                                   CourseTitle = y.CourseTitle,
                                   RegistrationNumber = student.RegistrationNumber
                               };*/
            return View("");

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

            /*List<CourseHasStudent> elements = _context.CourseHasStudents
                .Where(x => x.RegistrationNumber == student.RegistrationNumber && x.GradeCourseStudent >= 0)
                .ToList();

            List<Course> courses = _context.Courses.ToList();

            var coursetitles = from x in elements
                               join y in courses on x.IdCourse equals y.IdCourse
                               where x.RegistrationNumber == student.RegistrationNumber
                               select new Grade
                               {
                                   IdCourse = y.IdCourse,
                                   CourseTitle = y.CourseTitle,
                                   RegistrationNumber = student.RegistrationNumber
                               };*/
            return View("");

        }


    }
}
