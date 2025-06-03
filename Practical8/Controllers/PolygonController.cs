using Practical8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical8.Controllers
{
    public class PolygonController : Controller
    {
        // GET: Polygon
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectShape()
        {
            return View();
        }

        public ActionResult Circle()
        {
            return View();
        }

        //Rectangle
        public ActionResult Rectangle()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Rectangle(0, 0)); // initialize for the form
        }

        [HttpPost]
        public ActionResult Create(Rectangle model)
        {
            // You can validate here if needed
            Session["rectangle"] = model; // pass the model to the next view
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {
            var rectangle = Session["rectangle"] as Rectangle;
            if (rectangle == null)
            {
                return RedirectToAction("Create");
            }
            return View(rectangle);
        }

        //Ellipse
        public ActionResult Ellipse()
        {
            return View();
        }

        public ActionResult Triangle()
        {
            return View();
        }
    }
}