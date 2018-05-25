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

		public async Task<bool> InsertOneProduct(Product product)
		{
			return await _productRepo.InsertOneProduct(product);
		}

		public async Task<bool> InsertManyProduct(List<Product> products)
		{
			return await _productRepo.InsertManyProduct(products);
		}

		public async Task<bool> UpdateOneProduct(Product product)
		{
			return await _productRepo.UpdateOneProduct(product);
		}

		public async Task<bool> UpdateManyProduct(List<Product> products)
		{
			return await _productRepo.UpdateManyProduct(products);
		}

		public async Task<bool> DeleteOneProduct(int id)
		{
			return await _productRepo.DeleteOneProduct(id);
		}

		public async Task<bool> DeleteManyProduct()
		{
			return await _productRepo.DeleteManyProduct();
		}

	}
}
