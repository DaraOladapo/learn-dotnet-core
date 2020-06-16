using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.Models.Data;

namespace Portal.Controllers
{
    public class StudentController : Controller
    {
        List<Student> _Students = new List<Student>() {
            new Student(){ FirstName = "Dara", LastName = "Oladapo", EmailAddress = "me@daraoladapo.com", ID = 1 },
            new Student(){ FirstName = "Oluwadara", LastName = "Oladapo", EmailAddress = "dara@daraoladapo.com", ID = 2 },
        };
        // GET: StudentController
        public ActionResult Index()
        {
            return View(_Students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(long id)
        {
            var _Student = _Students.FirstOrDefault(opt => opt.ID == id);
            return View(_Student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var _Student = _Students.FirstOrDefault(opt => opt.ID == id);
            return View(_Student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var _Student = _Students.FirstOrDefault(opt => opt.ID == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
