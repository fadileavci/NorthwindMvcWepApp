using NorthwindMvcWepApp.DAL;
using NorthwindMvcWepApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindMvcWepApp.BLL
{
	public class CustomerBLL
	{

		public static NorthwindDbDataContext db = new NorthwindDbDataContext();

		public static List<Customer> GetCustomers()
		{

			return db.Customers.ToList();

		}

	}
}
