using EntityCRUD.Data;
using EntityCRUD.DataModels;
using EntityCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityCRUD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchString)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            HomeIndexViewModel viewmodel = new HomeIndexViewModel();

            if (searchString != null)
            {
                viewmodel.Customers = db.Customers.Include("Orders")
                                                  .Where(c => c.Name.Contains(searchString))
                                                  .ToList();
            }
            else
            {
            viewmodel.Customers = db.Customers.ToList();
            viewmodel.Orders = db.Orders.ToList();
            }

            return View(viewmodel);
        }

        
        public ActionResult NewCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCustomer(Customer newcustomer)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            HomeIndexViewModel viewmodel = new HomeIndexViewModel();

            db.Customers.Add(newcustomer);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            HomeIndexViewModel viewmodel = new HomeIndexViewModel();

            viewmodel.Customers = db.Customers.Where(c => c.Id == id).ToList();

            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(int id, Customer updatedcustomer)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            HomeIndexViewModel viewmodel = new HomeIndexViewModel();
            Customer customer = new Customer();

            customer = db.Customers.Find(id);
            customer.Name = updatedcustomer.Name;
            customer.Birthday = updatedcustomer.Birthday;

            db.SaveChanges();

            return View(viewmodel);
        }

        public ActionResult DeleteCustomer(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            HomeIndexViewModel viewmodel = new HomeIndexViewModel();

            Customer deletecustomer = db.Customers.Find(id);

            db.Customers.Remove(deletecustomer);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}