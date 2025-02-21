using CoreProject.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreProject.UI.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var valuesComment = new List<UserComment>
			{
				new UserComment
				{
					 Id = 1,
					 Username = "Test",
				},
				new UserComment {
					Id = 2,
					 Username="Test2",
				}
			};
			return View(valuesComment);
		}
	}
}
