﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi
{
    public class EntityContextBase<TContext> : DbContext, IEntityContext where TContext : DbContext
	{
		public EntityContextBase(DbContextOptions<TContext> options) : base(options)
		{
		}
	}
}
