﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Controllers
{
    public class LoginControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
