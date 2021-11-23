﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
