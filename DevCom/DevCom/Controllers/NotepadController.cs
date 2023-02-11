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
            NotepadViewModel myModel = new NotepadViewModel();
            myModel.Notepads = db.Notepads.ToList();
            //myModel.NoteContents = db.NoteContents.ToList();
            //myModel.Tags = db.Tags.ToList();
            myModel.Texts = db.Texts.ToList();
            myModel.Notepad = new Notepad();
            //myModel.NoteContent = new NoteContent();
            myModel.Text = new Text();
            //myModel.Tag = new Tag();
            return View(myModel);
        }

        public ActionResult Show(/*string noteid*/)
        {
            //var item = db.Notepads.Where(m => m.Notepad_Id == noteid).FirstOrDefault();
            return PartialView();
        }
    }
}