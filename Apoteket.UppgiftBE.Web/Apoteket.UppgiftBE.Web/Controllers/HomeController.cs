using System.Web.Mvc;
using Apoteket.UppgiftBE.Web.Data;

namespace Apoteket.UppgiftBE.Web.Controllers
{
	public class HomeController : Controller
	{
		readonly IProductList _productList;

		public HomeController(IProductList productList)
		{
			_productList = productList;
		}

		public ActionResult Index()
		{
			// Lista de produkter som finns i _productList
			return View();
		}
	}
}