using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationExamples.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public JsonResult CheckBlankText(string blankText)
		{
			if (string.IsNullOrEmpty(blankText.ToString()))
				return Json(true, JsonRequestBehavior.AllowGet);
			return Json(false, JsonRequestBehavior.AllowGet);
		}
	}
}