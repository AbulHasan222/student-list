using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDataCRUD_MVC.Models;
using System.Data;

namespace StudentDataCRUD_MVC.Controllers
{
    public class StudentController : Controller
    {
        PracticeDBEntities dbObj = new PracticeDBEntities();
        // GET: Student
        public ActionResult Student(dbl_student student)
        {
               return View(student);
        }

        [HttpPost]
        public ActionResult AddStudent(dbl_student model)
        {
            if (ModelState.IsValid)
            {
                dbl_student obj = new dbl_student();
                obj.ID = model.ID;
                obj.FirstName = model.FirstName;
                obj.LastName = model.LastName;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Address = model.Address;

                if(model.ID == 0)
                {
                    dbObj.dbl_student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
            }
            ModelState.Clear();

            return View("Student");
        }

        public ActionResult StudentList()
        {
            var studentList = dbObj.dbl_student.ToList();

            return View(studentList);
        }

        public ActionResult Delete(int id)
        {
            var res = dbObj.dbl_student.Where(x => x.ID == id).First();
            dbObj.dbl_student.Remove(res);
            dbObj.SaveChanges();

            var stList = dbObj.dbl_student.ToList();
            return View("StudentList", stList);
        }

    }
}