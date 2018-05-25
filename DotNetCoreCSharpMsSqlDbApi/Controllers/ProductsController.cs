using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetCoreCSharpMsSqlDbApi.Models;
using DotNetCoreCSharpMsSqlDbApi.Services;
using DotNetCoreCSharpMsSqlDbApi.IServices;

namespace DotNetCoreCSharpMsSqlDbApi.Controllers
{
	[Produces("application/json")]
	public class ProductsController : Controller
	{
		private readonly IProductService _productService = null;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[Route("api/Products")]
		[HttpGet]
		public string ProductApi()
		{
			return "Product Api is working";
		}

		[Route("api/Products/GetAllProducts")]
		[HttpGet]
		public async Task<List<Product>> GetAllProducts()
		{
			return await _productService.GetAllProducts();
		}

		[Route("api/Products/GetProductById/{id}")]
		[HttpGet]
		public async Task<Product> GetProductById(int id)
		{
			return await _productService.GetProductById(id);
		}

		[Route("api/Products/InsertOneProduct")]
		[HttpPost]
		public async Task<bool> InsertOneProduct([FromBody] Product product)
		{
			return await _productService.InsertOneProduct(product);
		}

		[Route("api/Products/InsertManyProduct")]
		[HttpPost]
		public async Task<bool> InsertManyProduct([FromBody] List<Product> products)
		{
			return await _productService.InsertManyProduct(products);
		}

		[Route("api/Products/UpdateOneProduct")]
		[HttpPut]
		public async Task<bool> UpdateOneProduct([FromBody] Product product)
		{
			return await _productService.UpdateOneProduct(product);
		}

		[Route("api/Products/InsertManyProduct")]
		[HttpPut]
		public async Task<bool> UpdateManyProduct([FromBody] List<Product> products)
		{
			return await _productService.UpdateManyProduct(products);
		}

		[Route("api/Products/DeleteOneProduct/{id}")]
		[HttpDelete]
		public async Task<bool> DeleteOneProduct(int id)
		{
			return await _productService.DeleteOneProduct(id);
		}

		[Route("api/Products/DeleteManyProduct")]
		[HttpPost]
		public async Task<bool> DeleteManyProduct()
		{
			return await _productService.DeleteManyProduct();
		}



	}
}