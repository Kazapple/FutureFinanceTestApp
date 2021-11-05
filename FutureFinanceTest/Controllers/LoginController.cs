using FutureFinanceTest.Models;
using FutureFinanceTest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureFinanceTest.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Processlogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();

            if(securityService.IsValid(userModel))
            {
                return View("LoginSucess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
