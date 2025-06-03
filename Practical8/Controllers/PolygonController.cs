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

        public ActionResult SelectShape(string shapeType)
        {
            if (shapeType == "Square")
            {
                return RedirectToAction("Square");
            }
            else if (shapeType == "Rectangle")
            {
                return RedirectToAction("Rectangle");
            }
            else if (shapeType == "Ellipse")
            {
                return RedirectToAction("Ellipse");
            }
            else if (shapeType == "Circle")
            {
                return RedirectToAction("Circle");
            }
            else
            {
                return View();
            }
        }

        public ActionResult RedirectToSelectShape()
        {
            return RedirectToAction("SelectShape");
        }

        //Square
        public ActionResult Square()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateSquare()
        {
            return View(new Square(0));
        }

        [HttpPost]
        public ActionResult CreateSquare(Square model)
        {
            Session["shape"] = model;
            return RedirectToAction("Display");
        }

         

        //Rectangle
        public ActionResult Rectangle()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateRectangle()
        {
            return View(new Rectangle(0, 0));
        }

        [HttpPost]
        public ActionResult CreateRectangle(Rectangle model)
        {
            Session["shape"] = model;
            return RedirectToAction("Display");
        }



        //Ellipse
        public ActionResult Ellipse()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEllipsee()
        {
            return View(new Ellipse(0, 0));
        }

        [HttpPost]
        public ActionResult CreateEllipse(Ellipse model)
        {
            Session["shape"] = model;
            return RedirectToAction("Display");
        }



        //Triangle
        public ActionResult Triangle()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateTriangle()
        {
            return View(new Triangle(0, 0));
        }

        [HttpPost]
        public ActionResult CreateTriangle(Triangle model)
        {
            Session["shape"] = model;
            return RedirectToAction("Display");
        }

        //Display
        public ActionResult Display()
        {
            var shape = Session["shape"] as Polygon;
            if (shape == null)
            {
                return RedirectToAction("CreateRectangle");
            }
            return View(shape);
        }
    }
}