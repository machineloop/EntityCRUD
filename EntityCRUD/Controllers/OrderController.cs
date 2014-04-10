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
    public class OrderController : Controller
    {       
        ApplicationDbContext db = new ApplicationDbContext();
        OrderViewModel model = new OrderViewModel();

        public ActionResult Index()
        {
            return View();
        }


        // GET: Order
        public ActionResult ListOrder()
        {
            model.VMOrders = db.Orders.ToList();
            return View(model);
        }

        public ActionResult AjaxListOrder()
        {
            model.VMOrders = db.Orders.ToList();
            return Json(model.VMOrders, JsonRequestBehavior.AllowGet);
        }

        // GET: Order
        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(string description, double ordertotal)
        {
            model.VMOrder = new Order();

            model.VMOrder.OrderDate = DateTime.Now;
            model.VMOrder.CustomerId = 1;

            model.VMOrder.Description = description;
            model.VMOrder.OrderTotal = ordertotal;

            db.Orders.Add(model.VMOrder);
            db.SaveChanges();

            ViewBag.SuccessMessage = "Congrats, you just added an order!";
            return View(model);
        }

        [HttpPost]
        public ActionResult AjaxAddOrder(string description, double ordertotal)
        {
            model.VMOrder = new Order();

            model.VMOrder.OrderDate = DateTime.Now;
            model.VMOrder.CustomerId = 1;

            model.VMOrder.Description = description;
            model.VMOrder.OrderTotal = ordertotal;

            db.Orders.Add(model.VMOrder);
            db.SaveChanges();

            ViewBag.SuccessMessage = "Congrats, you just added an order!";
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult EditOrder(int id)
        {
            model.VMOrder = new Order();
            model.VMOrder = db.Orders.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditOrder(int id, string description, double ordertotal)
        {
            model.VMOrder = db.Orders.Find(id);

            model.VMOrder.Description = description;
            model.VMOrder.OrderTotal = ordertotal;

            db.SaveChanges();

            ViewBag.SuccessMessage = "Congrats, you just edited an order!";
            return View(model);
        }

        public ActionResult DeleteOrder(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}