using Microsoft.AspNetCore.Mvc;

namespace CoreProject.UI.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error(int code)
		{

			return View();
		}
	}
}
