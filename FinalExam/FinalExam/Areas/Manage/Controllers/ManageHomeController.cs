﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Areas.Manage.Controllers
{ 
    [Area("Manage")]
  
    public class ManageHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
