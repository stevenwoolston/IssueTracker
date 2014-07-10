using IssueTracker.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTracker.Domain;
using IssueTracker.Data.DataContext;

namespace IssueTracker.Data
{
    public class ThreadRepository
    {
        private IssuesEntities context;
        public ThreadRepository()
        {
            this.context = new IssuesEntities();
        }

        public IQueryable<Domain.Thread> GetThreads()
        {
            return (from threads in context.Thread 
                    select threads);
        }

        public Thread GetThreadById(int threadId)
        {
            Thread entity = this.Get().Where(item => item.Id == threadId).SingleOrDefault();
            return entity;
        }

        public int AddThread(Thread thread)
        {
            context.Thread.Add(thread);
            context.SaveChanges();
            return thread.Id;
        }

        public int UpdateThread(Thread thread)
        {
            context.Thread.Attach(thread);
            context.Entry(thread).State = EntityState.Modified;
            context.SaveChanges();
            return thread.Id;
        }

        public bool DeleteThread(int threadId)
        {
            try
            {
                Thread entity = this.Get().Where(item => item.Id == threadId).SingleOrDefault();
                context.Thread.Attach(entity);
                context.Thread.Remove(entity);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        #region Helpers
        private IQueryable<Thread> Get()
        {
            return this.context.Thread.Include("Message").Include("ThreadAttachment").Select(currentRecord => currentRecord);
        }
        #endregion
    }
}
