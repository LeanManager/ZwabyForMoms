using System;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace ZwabyBeta
{
	public class CustomerDatabase
	{
		readonly SQLiteAsyncConnection database;

		public CustomerDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Customer>().Wait();
		}

		// SQLite.NET queries

		public Task<int> SaveCustomerAsync(Customer customer)
		{
			if (customer.CustomerId != 0)
			{
				return database.UpdateAsync(customer);
			}
			else
			{
				return database.InsertAsync(customer);
			}
		}



	}
}
