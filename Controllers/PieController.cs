using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace PieShop.Controllers
{
	public class PieController : Controller
	{
		private readonly IPieRepo _pieRepo;
		private readonly ICategoryRepo _categoryRepo;

		public PieController(IPieRepo pieRepo, ICategoryRepo categoryRepo) 
		{
			_pieRepo = pieRepo;
			_categoryRepo = categoryRepo;
		}

		public ViewResult List()
		{
			ViewBag.NewCategory = "Great";
			return View();
		}
		/*public IActionResult Index()
		{
			return View();
		}*/
	}
}
