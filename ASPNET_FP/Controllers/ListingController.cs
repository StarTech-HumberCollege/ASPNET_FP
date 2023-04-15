using ASPNET_FP.Data;using ASPNET_FP.Models;using Microsoft.AspNetCore.Mvc;using Microsoft.EntityFrameworkCore;namespace ASPNET_FP.Controllers{
    public class ListingController : Controller
    {
        private readonly MyLesseeDBContext context;

        public ListingController(MyLesseeDBContext myLesseeDBContext)
        {
            this.context = myLesseeDBContext;
        }        // show all listings        public IActionResult Index()        {            var listings = context.Listings                .Include(l => l.HouseType)                .OrderBy(l => l.ListingId)                .ToList();            return View(listings);        }        /*// show all listings with filter on houseType and rentalPrice        public IActionResult Index(string houseType, string rentalPrice)
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
        }*/        [HttpGet]        public IActionResult Details(int id)        {            var l = context.Listings.Find(id);            return View(l);        }        [HttpGet]        public IActionResult Add()        {            ViewBag.Action = "Add";            ViewBag.HouseTypes = context.HouseTypes.OrderBy(ht => ht.Type).ToList();            return View("Edit", new Listing());        }        [HttpGet]        public IActionResult Edit(int id)        {            ViewBag.Action = "Edit";            ViewBag.HouseTypes = context.HouseTypes.OrderBy(ht => ht.Type).ToList();            var l = context.Listings.Find(id);            return View(l);        }        [HttpPost]        public IActionResult Edit(Listing l)        {            if (ModelState.IsValid)            {                if (l.ListingId == 0)                {                    context.Listings.Add(l);                }                else                {                    context.Listings.Update(l);                }                context.SaveChanges();                return RedirectToAction("Index", "Listing");            }            else            {                ViewBag.Action = (l.ListingId == 0) ? "Add" : "Edit";                ViewBag.HouseTypes = context.HouseTypes.OrderBy(ht => ht.Type).ToList();                return View(l);            }        }        [HttpGet]        public IActionResult Delete(int id)        {            var l = context.Listings.Find(id);            return View(l);        }        [HttpPost]        public IActionResult Delete(Listing l)        {            context.Listings.Remove(l);            context.SaveChanges();            return RedirectToAction("Index", "Listing");        }    }}