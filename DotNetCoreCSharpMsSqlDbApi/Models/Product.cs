using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi.Models
{
	public class Product : EntityBase
	{

		public string ProductName { get; set; }

		public string ProductDescription { get; set; }

		public int Amount { get; set; }

		public bool ActiveStatus { get; set; }
	}
}
