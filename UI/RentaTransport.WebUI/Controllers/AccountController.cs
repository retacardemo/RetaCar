using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RentaTransport.WebUI.Controllers
{
    public class AccountController : CrudController
    {
        [HttpGet]
        public IActionResult Login()
        {
            return PartialView("_LoginPartial");
        }

        [HttpPost]
        public IActionResult SinIn()
        {
            return null;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return PartialView("_RegisterPartial");
        }

        [HttpPost]
        public IActionResult Signup()
        {
            return null;
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return PartialView("_ForgotPasswordPartial");
        }

        [HttpPost]
        public IActionResult ResetPassword()
        {
            return null;
        }
    }
}