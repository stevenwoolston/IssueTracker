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
        protected readonly ThreadBusiness threadBusiness;
        public ThreadViewModelBuilder()
        {
            this.threadBusiness = new ThreadBusiness();
        }

        public List<Thread> GetAllThreads()
        {
            List<Thread> threads = threadBusiness.GetThreads();
            return threads;
        }

        public Thread GetThreadById(int id)
        {
            Thread thread = threadBusiness.GetThreadById(id);
            return thread;
        }

        public int CreateThread(Thread thread)
        {
            int id = threadBusiness.AddThread(thread);
            return id;
        }

        public int UpdateThread(Thread thread)
        {
            int id = threadBusiness.UpdateThread(thread);
            return id;
        }

        public bool DeleteThread(int id)
        {
            bool result = threadBusiness.DeleteThread(id);
            return result;
        }
    }
}