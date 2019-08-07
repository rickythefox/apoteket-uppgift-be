using System.Collections.Generic;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Data
{
	public interface IBasket
	{
		IReadOnlyList<Product> GetProducts();
		void AddProduct(string itemId);
		void RemoveProduct(string itemId);
		string Checkout();
	}

	public class Basket : IBasket
	{
		public IReadOnlyList<Product> GetProducts()
		{
			// Get from db using Entity Framework or linq2db (https://github.com/linq2db/linq2db)
			return new List<Product>();
		}

		public void AddProduct(string productId)
		{
			// Get from db using Entity Framework or linq2db (https://github.com/linq2db/linq2db)
		}

		public void RemoveProduct(string productId)
		{
			// Get from db using Entity Framework or linq2db (https://github.com/linq2db/linq2db)
		}

		public string Checkout()
		{
			// Checkout the basket and return the id provided by order service
			return "";
		}
	}
}