using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RentaTransport.AdminUI.Controllers
{
    //[Authorize]
    [Route("[controller]/[action]/{id?}")]
    //[Route("{culture:culture}/[controller]/[action]")]
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewData["ActionName"] = context.ActionDescriptor.RouteValues["action"];
            ViewData["ControllerName"] = context.ActionDescriptor.RouteValues["controller"];
            ViewData["Title"] = ViewData["ControllerName"] + " / " + ViewData["ActionName"];
        }
    }
}