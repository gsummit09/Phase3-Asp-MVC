using AssignmentJan31.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentJan31.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course() {CId=1001,CName="Full-Stack",CFee=35000,Technology="Java",CStartDate=new DateTime(day:23,month:11,year:2022),CEndDate=new DateTime(day:10,month:10,year:2023)},
            new Course() {CId=1002,CName="Full-Stack",CFee=25000,Technology=".Net",CStartDate=new DateTime(day:15,month:6,year:2023),CEndDate=new DateTime(day:10,month:12,year:2023)},
            new Course() {CId=1003,CName="Data Science",CFee=30000,Technology="Python",CStartDate=new DateTime(day:23,month:05,year:2022),CEndDate=new DateTime(day:6,month:10,year:2023)},
            new Course() {CId=1004,CName="Testing",CFee=35000,Technology="Selenium",CStartDate=new DateTime(day:10,month:05,year:2022),CEndDate=new DateTime(day:10,month:03,year:2023)},
            new Course() {CId=1005,CName="UI/UX",CFee=35000,Technology="Frond-End",CStartDate=new DateTime(day:23,month:11,year:2022),CEndDate=new DateTime(day:10,month:10,year:2023)}
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course crs)
        {
            if(ModelState.IsValid)
            {
                courses.Add(crs);
                return RedirectToAction("Index");
            }
            return View(crs);
        }
    }
}