using DotNetCoreCSharpMsSqlDbApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi.IServices
{
	public interface IProductService
	{
		Task<List<Product>> GetAllProducts();
		Task<Product> GetProductById(int id);
		//Task<Product> GetProductById(int id);
		//Task<bool> InsertOneProduct(Product product);
		//Task<bool> InsertManyProduct(List<Product> products);
		//Task<bool> UpdateOneProduct(Product product);
		//Task<bool> UpdateManyProduct(List<Product> products);
		//Task<bool> DeleteOneProduct(int id);
		//Task<bool> DeleteManyProduct();
	}
}
