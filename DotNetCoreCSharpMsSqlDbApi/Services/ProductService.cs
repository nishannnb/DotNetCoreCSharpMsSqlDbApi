using DotNetCoreCSharpMsSqlDbApi.IServices;
using DotNetCoreCSharpMsSqlDbApi.Models;
using DotNetCoreCSharpMsSqlDbApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi.Services
{
	public class ProductService : IProductService
	{
		private ProductRepo _productRepo = null;


		public ProductService(MsSqlDbContext msSqlDbContext)
		{
			_productRepo = new ProductRepo(msSqlDbContext);
		}

		public async Task<List<Product>> GetAllProducts()
		{
			return await _productRepo.GetAllProducts();
		}

		public async Task<Product> GetProductById(int id)
		{
			return await _productRepo.GetProductById(id);
		}
	}
}
