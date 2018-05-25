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









		//// GET: api/Products
		//[HttpGet]
		//public IEnumerable<Product> GetProduct()
		//{
		//	return _context.Product;
		//}

		//// GET: api/Products/5
		//[HttpGet("{id}")]
		//public async Task<IActionResult> GetProduct([FromRoute] int id)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);

		//	if (product == null)
		//	{
		//		return NotFound();
		//	}

		//	return Ok(product);
		//}

		//// PUT: api/Products/5
		//[HttpPut("{id}")]
		//public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product product)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	if (id != product.Id)
		//	{
		//		return BadRequest();
		//	}

		//	_context.Entry(product).State = EntityState.Modified;

		//	try
		//	{
		//		await _context.SaveChangesAsync();
		//	}
		//	catch (DbUpdateConcurrencyException)
		//	{
		//		if (!ProductExists(id))
		//		{
		//			return NotFound();
		//		}
		//		else
		//		{
		//			throw;
		//		}
		//	}

		//	return NoContent();
		//}

		//// POST: api/Products
		//[HttpPost]
		//public async Task<IActionResult> PostProduct([FromBody] Product product)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	_context.Product.Add(product);
		//	await _context.SaveChangesAsync();

		//	return CreatedAtAction("GetProduct", new { id = product.Id }, product);
		//}

		//// DELETE: api/Products/5
		//[HttpDelete("{id}")]
		//public async Task<IActionResult> DeleteProduct([FromRoute] int id)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);
		//	if (product == null)
		//	{
		//		return NotFound();
		//	}

		//	_context.Product.Remove(product);
		//	await _context.SaveChangesAsync();

		//	return Ok(product);
		//}

		//private bool ProductExists(int id)
		//{
		//	return _context.Product.Any(e => e.Id == id);
		//}
	}
}