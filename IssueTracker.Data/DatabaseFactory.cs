using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Data
{
    public class DatabaseFactory<CONTEXT> : Disposable, IDatabaseFactory<CONTEXT> where CONTEXT : ObjectContext
    {
        private CONTEXT dataContext;
        public CONTEXT Get()
        {
            if (typeof(CONTEXT) == typeof(ObjectContext))
                return default(ObjectContext) as CONTEXT;
            return dataContext ?? (dataContext = Activator.CreateInstance<CONTEXT>());

        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
