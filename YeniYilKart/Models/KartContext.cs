using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YeniYilKart.Models
{
	public class KartContext : DbContext
	{
		public KartContext() : base("name=KartContext")
		{

		}
		public DbSet<Kart> Kartlar { get; set; }
	}
}