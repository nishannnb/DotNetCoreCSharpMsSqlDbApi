using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi
{
	public static class Extention
	{
		public static IServiceCollection AddDataAccess<TEntityContext>(this IServiceCollection services) where TEntityContext : EntityContextBase<TEntityContext>
		{
			RegisterDataAccess<TEntityContext>(services);
			return services;
		}

		private static void RegisterDataAccess<TEntityContext>(IServiceCollection services) where TEntityContext : EntityContextBase<TEntityContext>
		{
			services.TryAddTransient<IEntityContext, TEntityContext>();
		}
	}
}
