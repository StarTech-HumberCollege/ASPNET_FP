<<<<<<< HEAD
﻿using ASPNET_FP.Data;
using ASPNET_FP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
=======
﻿using ASPNET_FP.Data;
using ASPNET_FP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
>>>>>>> 86fef26f3cb672ccb92a9b900a74f7f0549a018e
using System.Diagnostics;

namespace ASPNET_FP.Controllers
{
	public class HomeController : Controller
	{
<<<<<<< HEAD
		private readonly MyLesseeDBContext context;

		public HomeController(MyLesseeDBContext myLesseeDBContext)
		{
			this.context = myLesseeDBContext;
		}

		// show all listings with filter on houseType and rentalPrice
		public IActionResult Index(string houseType, string rentalPrice)
		{
			var listings = context.Listings
				.Include(l => l.HouseType)
				.OrderBy(l => l.ListingId)
				.ToList();

			if (!string.IsNullOrEmpty(houseType))
			{
				listings = listings.Where(l => l.HouseType.Type == houseType).ToList();
			}

			if (!string.IsNullOrEmpty(rentalPrice))
			{
				double price = double.Parse(rentalPrice);
				listings = listings.Where(l => l.RentalPrice >= price).ToList();
			}

			ViewBag.HouseTypes = context.HouseTypes.OrderBy(ht => ht.Type).ToList();

			return View(listings);
=======
		private readonly MyLesseeDBContext context;

		public HomeController(MyLesseeDBContext myLesseeDBContext)
		{
			this.context = myLesseeDBContext;
		}

		// show all listings with filter on houseType and rentalPrice
		public IActionResult Index(string houseType, string rentalPrice)
		{
			var listings = context.Listings
				.Include(l => l.HouseType)
				.OrderBy(l => l.ListingId)
				.ToList();

			if (!string.IsNullOrEmpty(houseType))
			{
				listings = listings.Where(l => l.HouseType.Type == houseType).ToList();
			}

			if (!string.IsNullOrEmpty(rentalPrice))
			{
				double price = double.Parse(rentalPrice);
				listings = listings.Where(l => l.RentalPrice >= price).ToList();
			}

			ViewBag.HouseTypes = context.HouseTypes.OrderBy(ht => ht.Type).ToList();

			return View(listings);
>>>>>>> 86fef26f3cb672ccb92a9b900a74f7f0549a018e
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}