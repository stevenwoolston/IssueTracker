using System.Web.Mvc;

namespace IssueTracker.Web.Areas.Threads
{
    public class ThreadsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Threads";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Threads_default",
                "Threads/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
