using DotNetCoreCSharpMsSqlDbApi.Models;
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


		public IEnumerable<Product> GetAllProductsEnu()
		{
			try
			{
				return _msSqlDbContext.Products.AsEnumerable();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Product> GetAllProductsList()
		{
			try
			{
				return _msSqlDbContext.Products.ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}
}
