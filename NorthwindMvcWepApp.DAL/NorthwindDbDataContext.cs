using NorthwindMvcWepApp.DAL.Mapping;
using NorthwindMvcWepApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindMvcWepApp.DAL
{
	 public class NorthwindDbDataContext:DbContext
	{
		public NorthwindDbDataContext() : base("name=NorthwindConnectionStringAdi")
		{

			Database.SetInitializer<NorthwindDbDataContext>(null);
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new CustomerMapping());
		}

		public virtual DbSet<Customer> Customers { get; set; }
	}
}
