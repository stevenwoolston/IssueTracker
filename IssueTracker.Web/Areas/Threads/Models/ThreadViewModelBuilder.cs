using IssueTracker.Business;
using IssueTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssueTracker.Web.Areas.Threads.Models
{
    public class ThreadViewModelBuilder
    {
        protected readonly IThreadBusiness iThreadBusiness;
        public ThreadViewModelBuilder(IThreadBusiness iThreadBusiness)
        {
            this.iThreadBusiness = iThreadBusiness;
        }

        public List<Thread> GetAllThreads()
        {
            List<Thread> threads = iThreadBusiness.GetThreads();
            return threads;
        }

        public Thread GetThreadById(int id)
        {
            Thread thread = iThreadBusiness.GetThreadById(id);
            return thread;
        }

        public int CreateThread(Thread thread)
        {
            int id = iThreadBusiness.AddThread(thread);
            return id;
        }

        public int UpdateThread(Thread thread)
        {
            int id = iThreadBusiness.UpdateThread(thread);
            return id;
        }

        public bool DeleteThread(int id)
        {
            bool result = iThreadBusiness.DeleteThread(id);
            return result;
        }
    }
}