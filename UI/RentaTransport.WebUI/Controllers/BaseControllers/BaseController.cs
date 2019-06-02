using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RentaTransport.WebUI.Controllers.BaseControllers
{
    //[Authorize]
    [Route("[controller]/[action]/{id?}")]
    [Route("{culture:culture}/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewData["ActionName"] = context.ActionDescriptor.RouteValues["action"];
            ViewData["ControllerName"] = context.ActionDescriptor.RouteValues["controller"];
            ViewData["Title"] = ViewData["ControllerName"] + " / " + ViewData["ActionName"];
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return LocalRedirect(returnUrl);
        }
    }
}