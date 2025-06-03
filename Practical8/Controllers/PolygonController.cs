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
            else if (shapeType == "Triangle")
            {
                return RedirectToAction("Triangle");
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

        private List<Polygon> Shapes
        {
            get
            {
                if (Session["Shapes"] == null)
                {
                    Session["Shapes"] = new List<Polygon>();
                }
                return (List<Polygon>)Session["Shapes"];
            }
            set
            {
                Session["Shapes"] = value;
            }
        }

        //Display
        public ActionResult Display()
        {
            var shapes = Shapes;
            return View(shapes);
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
            Shapes.Add(model);
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
            Shapes.Add(model);
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
            Shapes.Add(model);
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
            Shapes.Add(model);
            return RedirectToAction("Display");
        }

        /*
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
        */



    }
}