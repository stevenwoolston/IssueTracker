using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IssueTracker.Data.DataContext;
using IssueTracker.Domain;
using IssueTracker.Data;
using IssueTracker.Data.Repository;

namespace IssueTracker.Business
{
    public class ThreadBusiness : IThreadBusiness
    {
        IThreadRepository<IssuesEntities> iThreadRepository = null;
        public ThreadBusiness(IThreadRepository<IssuesEntities> iThreadRepository)
        {
            this.iThreadRepository = iThreadRepository;
        }

        public List<Thread> GetThreads()
        {
            return iThreadRepository.GetThreads().ToList();
        }

        public Thread GetThreadById(int threadId)
        {
            return iThreadRepository.GetThreadById(threadId);
        }

        public int AddThread(Thread thread)
        {
            return iThreadRepository.AddThread(thread);
        }

        public int UpdateThread(Thread thread)
        {
            return iThreadRepository.UpdateThread(thread);
        }

        public bool DeleteThread(int threadId)
        {
            return iThreadRepository.DeleteThread(threadId);
        }
    }
}
