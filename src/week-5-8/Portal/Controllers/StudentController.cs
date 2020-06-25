using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.Data;
using Portal.Models.Binding;
using Portal.Models.Data;
using Portal.Models.View;

namespace Portal.Controllers
{
    //TODO: Explain DB Context in details at Week 7 Sec 2
    public class StudentController : Controller
    {
        readonly ApplicationDbContext _DBContext;
        public StudentController(ApplicationDbContext dbContext)
        {
            _DBContext = dbContext;
        }

        public ActionResult Index()
        {
            var _Students = _DBContext.Students.ToList();
            return View(_Students);
        }
        public ActionResult Details(long id)
        {
            var _Student = _DBContext.Students.FirstOrDefault(opt => opt.ID == id);
            var _StudentViewModel = new StudentViewModel()
            {
                ID=_Student.ID,
                FirstName = _Student.FirstName,
                LastName = _Student.LastName,
                EmailAddress = _Student.EmailAddress
            };
            ViewBag.Name = _StudentViewModel.FullName;
            TempData["Student"] = "Dara";
            return RedirectToAction("AnotherDetail");
        }
        public ActionResult AnotherDetail()
        {
            var Query = this.Request.QueryString;
            ViewBag.Info = Query;
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost("add")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection Collection)
        {
             try
            {
                var CreatedStudent = new Student()
                {
                    FirstName = Collection["FirstName"],
                    LastName = Collection["LastName"],
                    EmailAddress = Collection["EmailAddress"]
                };
                _DBContext.Students.Add(CreatedStudent);
                _DBContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public async Task<ActionResult<Student>> Create([FromBody]AddStudentBindingModel bindingModel)
        {
            if (ModelState.IsValid)
            {
                var StudentToCreate=new Student(){
                    FirstName=bindingModel.FirstName,
                    LastName=bindingModel.LastName,
                    EmailAddress=bindingModel.EmailAddress,
                    CreatedDate=DateTime.Now
                };
                var StudentAdded=_DBContext.Students.Add(StudentToCreate).Entity;
                await _DBContext.SaveChangesAsync();
                return Ok(StudentAdded);
            }
            else
            {
                return BadRequest("Invalid input");
            }
        }
        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var _Student = _DBContext.Students.FirstOrDefault(opt => opt.ID == id);
            return View(_Student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var _Student = _DBContext.Students.FirstOrDefault(opt => opt.ID == id);
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
