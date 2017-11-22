using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapidBudgetManager.Controllers
{
    public class TransactionsController : Controller
    {
        // GET: Transactions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}