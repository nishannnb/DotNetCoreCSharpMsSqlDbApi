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

		public IEnumerable<Product> GetAllProductsEnu()
		{
			return _productRepo.GetAllProductsEnu();
		}

		public List<Product> GetAllProductsList()
		{
			return _productRepo.GetAllProductsList();
		}
	}
}
