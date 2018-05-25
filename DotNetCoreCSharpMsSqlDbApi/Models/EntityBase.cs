using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCSharpMsSqlDbApi.Models
{
	public class EntityBase
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
	}
}
