using Mvc_School_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_School_app.Controllers
{
    public class PupilController : Controller
    {
       public  Pupil[] Pupils = new Pupil[]{
         new Pupil(0,"yafit", "samuuel", 12, "aa"),
         new Pupil(1,"romi", "samuuel", 13, "bb"),
         new Pupil(2,"lior", "dana", 14, "cc"),
         new Pupil(3,"tal", "ron", 15, "dd")
       };

        // GET: Pupil
        public ActionResult Index()
        {
            ViewBag.firstName = Pupils[0].firstName;
            return View(Pupils[0]);
        }

        public ActionResult GetAllPupils()
        {

            return View(Pupils);
        }

        public ActionResult PupilsById(int Id)
        {
            foreach (Pupil item in Pupils)
            {
                if (item.id == Id)
                {
                    return View(item);
                }
            }
            return View();
        }
    }
}