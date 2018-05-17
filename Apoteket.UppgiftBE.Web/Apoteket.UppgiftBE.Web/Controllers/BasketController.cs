using System.Web.Mvc;
using Apoteket.UppgiftBE.Web.Data;

namespace Apoteket.UppgiftBE.Web.Controllers
{
	public class BasketController : Controller
	{
		readonly IBasket _basket;

		public BasketController(IBasket basket)
		{
			_basket = basket;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Add(int id)
		{
			// Add item to basket
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Remove(int id)
		{
			// Remove item from basket
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Checkout()
		{
			// Checka ut korgen och visa erhållet ordernummer
			throw new System.NotImplementedException();
		}
	}
}