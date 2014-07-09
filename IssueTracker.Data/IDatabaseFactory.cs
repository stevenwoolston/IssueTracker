using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Data
{
    public interface IDatabaseFactory<CONTEXT> : IDisposable where CONTEXT : ObjectContext
    {
        CONTEXT Get();
    }
}
