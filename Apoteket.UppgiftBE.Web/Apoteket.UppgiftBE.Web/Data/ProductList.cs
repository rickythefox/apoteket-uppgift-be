using System.Collections.Generic;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Data
{
	public interface IProductList
	{
		IReadOnlyList<Product> Get();
	}

	public class ProductList : IProductList
	{
		IReadOnlyList<Product> _products;

		public ProductList()
		{
			// Hämta produktlistan med hjälp av RestSharp och lagra i Products
			// Observera att listan ändras en gång per timme
			_products = new List<Product>();
		}

		public IReadOnlyList<Product> Get() => _products;
	}
}