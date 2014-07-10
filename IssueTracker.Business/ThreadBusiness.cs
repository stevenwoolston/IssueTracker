using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IssueTracker.Data.DataContext;
using IssueTracker.Domain;
using IssueTracker.Data;

namespace IssueTracker.Business
{
    public class ThreadBusiness
    {
        ThreadRepository threadRepository = null;
        public ThreadBusiness()
        {
            this.threadRepository = new ThreadRepository();
        }

        public List<Thread> GetThreads()
        {
            return threadRepository.GetThreads().ToList();
        }

        public Thread GetThreadById(int threadId)
        {
            return threadRepository.GetThreadById(threadId);
        }

        public int AddThread(Thread thread)
        {
            return threadRepository.AddThread(thread);
        }

        public int UpdateThread(Thread thread)
        {
            return threadRepository.UpdateThread(thread);
        }

        public bool DeleteThread(int threadId)
        {
            return threadRepository.DeleteThread(threadId);
        }
    }
}
