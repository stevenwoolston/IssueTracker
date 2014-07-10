using Autofac;
using Autofac.Integration.Mvc;
using IssueTracker.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IssueTracker.Web
{
    public class Bootstrapper
    {
        public static void Run(){
            var builder = new ContainerBuilder(); 
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType(typeof(ThreadBusiness)).AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}