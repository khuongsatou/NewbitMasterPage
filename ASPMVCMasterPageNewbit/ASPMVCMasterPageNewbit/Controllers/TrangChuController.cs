﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCMasterPageNewbit.Controllers
{
    public class TrangChuController : Controller
    {
        //
        // GET: /TrangChu/
        public ActionResult Index()
        {
            return View("Index","_MyLayoutMasterPage");
        }
	}
}