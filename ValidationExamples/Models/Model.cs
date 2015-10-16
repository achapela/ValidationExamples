using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationExamples.Models
{
	public class Model
	{
		//[Remote("CheckBlankText", "Home", ErrorMessage = "Should be blank", HttpMethod = "POST")]
		public string BlankText { get; set; }
	}
}