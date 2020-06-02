using Labb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Services
{
	public class ProductService : IProductService
	{
		private readonly ApiService apiService;

		public ProductService(ApiService apiService)
		{
			this.apiService = apiService;
		}

		public IEnumerable<Product> GetAll()
		{
			return apiService.GetAll<Product>($"api/products/getall");
		}

		public Product GetByID(int id)
		{
			return apiService.GetOne<Product>($"api/products/getbyid?id={id}");
		}
	}
}
