using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueTracker.Domain;
using IssueTracker.Web.Areas.Threads.Models;

namespace IssueTracker.Web.Areas.Threads.Controllers
{
    public class ThreadController : Controller
    {
        private ThreadViewModelBuilder _builder = null;
        public ThreadController()
        {
            _builder = new ThreadViewModelBuilder();
        }
        //
        // GET: /Threads/Thread/

        public ActionResult Index()
        {
            List<Thread> model = _builder.GetAllThreads();
            return View(model);
        }

    }
}