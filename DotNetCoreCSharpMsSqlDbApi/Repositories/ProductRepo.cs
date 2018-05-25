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


	}
}
