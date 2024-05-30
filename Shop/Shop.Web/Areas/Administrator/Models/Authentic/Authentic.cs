using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Shop.Web.Areas.Administrator.Models.Authentic
{
    public class Authentic : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("UserName") == null)
            {
                context.Result = new RedirectToRouteResult
                (new RouteValueDictionary
                {
                        {"Controller","Access" },
                        {"Action","Login" }
                });
            }
        }
    }
}
