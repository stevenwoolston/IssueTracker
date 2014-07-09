using IssueTracker.Data;
using IssueTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Business
{
    public interface IThreadBusiness
    {
        List<Thread> GetThreads();
        Thread GetThreadById(int threadId);
        int AddThread(Thread thread);
        int UpdateThread(Thread thread);
        bool DeleteThread(int threadId);
    }
}
