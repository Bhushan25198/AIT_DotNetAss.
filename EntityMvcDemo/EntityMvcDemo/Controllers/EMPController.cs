using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityMvcDemo.Models;

namespace EntityMvcDemo.Controllers
{
    public class EMPController : Controller
    {
        // GET: EMP
        public ActionResult Index()
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            return View(ent.EMPLOYEES);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(EMPLOYEE e)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            ent.EMPLOYEES.Add(e);
            ent.SaveChanges();
            return View();

        }

        public ActionResult Edit(int id)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            EMPLOYEE e = ent.EMPLOYEES.Find(id);
            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(EMPLOYEE e)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            EMPLOYEE obj = ent.EMPLOYEES.Find(e.EMPLOYEE_ID);
            obj.EMPLOYEE_ID = e.EMPLOYEE_ID;
            obj.FIRST_NAME = e.FIRST_NAME;
            obj.LAST_NAME = e.LAST_NAME;
            obj.EMAIL = e.EMAIL;
            obj.PHONE_NUMBER = e.PHONE_NUMBER;
            obj.HIRE_DATE = e.HIRE_DATE;
            obj.JOB_ID = e.JOB_ID;
            obj.SALARY = e.SALARY;
            obj.COMMISSION_PCT = e.COMMISSION_PCT;
            obj.MANAGER_ID = e.MANAGER_ID;
            obj.DEPARTMENT_ID = e.DEPARTMENT_ID;
            ent.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            EMPLOYEE e = ent.EMPLOYEES.Find(id);
            return View(e);
        }

        [HttpPost]

        public ActionResult Delete(EMPLOYEE e)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            EMPLOYEE obj = ent.EMPLOYEES.Find(e.EMPLOYEE_ID);
            ent.EMPLOYEES.Remove(obj);
            ent.SaveChanges();
            return View();
        }

        public ActionResult Details(int id)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            EMPLOYEE e = ent.EMPLOYEES.Find(id);
            return View(e);
        }

        [HttpPost]

        public ActionResult Details(FormCollection collection)
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            ent.EMPLOYEES.Find(Convert.ToInt32(collection["EMPLOYEE_ID"].ToString()));
            return View();
        }
       
    }
}