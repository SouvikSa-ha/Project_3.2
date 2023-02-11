using DevCom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevCom.Controllers
{
    public class NotepadController : Controller
    {
        DevComDBEntities db = new DevComDBEntities();
        // GET: Notepad
        public ActionResult Index()
        {
            var data = db.Notepads.ToList();
            return View(data);
        }

        public ActionResult Show(/*string noteid*/)
        {
            //var item = db.Notepads.Where(m => m.Notepad_Id == noteid).FirstOrDefault();
            return PartialView();
        }
    }
}