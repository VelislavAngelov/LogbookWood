﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogbookWood.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult IndexUser()
        {
            return this.View();
        }
    }
}
