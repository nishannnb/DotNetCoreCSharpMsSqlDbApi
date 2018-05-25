using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetCoreCSharpMsSqlDbApi.Models;
using DotNetCoreCSharpMsSqlDbApi;

public class MsSqlDbContext : DbContext
{
	public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options)
		: base(options)
	{

	}

	public DbSet<Product> Products { get; set; }

}
