using DotNetCoreCSharpMsSqlDbApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi.Repositories
{
	public class ProductRepo
	{
		private MsSqlDbContext _msSqlDbContext = null;


		public ProductRepo(MsSqlDbContext msSqlDbContext)
		{
			_msSqlDbContext = msSqlDbContext;
		}


		public async Task<List<Product>> GetAllProducts()
		{
			try
			{
				var result = await _msSqlDbContext.Products.ToListAsync();
				return result;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<Product> GetProductById(int id)
		{
			try
			{
				return await _msSqlDbContext.Products.FindAsync(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> InsertOneProduct(Product product)
		{
			try
			{
				_msSqlDbContext.Products.Add(product);
				await _msSqlDbContext.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> InsertManyProduct(List<Product> products)
		{
			try
			{
				await _msSqlDbContext.Products.AddRangeAsync(products);
				await _msSqlDbContext.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> UpdateOneProduct(Product product)
		{
			try
			{
				var result = _msSqlDbContext.Products.Find(product.Id);
				if (result != null)
				{
					_msSqlDbContext.Entry(result).CurrentValues.SetValues(product);
					await _msSqlDbContext.SaveChangesAsync();
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> UpdateManyProduct(List<Product> products)
		{
			try
			{
				foreach (var prod in products)
				{
					var result = await GetProductById(prod.Id);

					if (result != null)
					{
						_msSqlDbContext.Products.Update(result);
						await _msSqlDbContext.SaveChangesAsync();

					}
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> DeleteOneProduct(int id)
		{
			try
			{
				var result = await GetProductById(id);
				if (result != null)
				{
					_msSqlDbContext.Products.Remove(result);
					await _msSqlDbContext.SaveChangesAsync();
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> DeleteManyProduct()
		{
			try
			{
				var result = await GetAllProducts();

				foreach (var prod in result)
				{
					_msSqlDbContext.Products.Update(prod);
					await _msSqlDbContext.SaveChangesAsync();
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
