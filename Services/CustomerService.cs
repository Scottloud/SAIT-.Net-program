using SQLite;
using FinalOOProject.Data;

namespace FinalOOProject.Services
{
	/* 
	 * Framework to create a new CustomerService object
	 * Author: Connor DeHaas
	 */
	public class CustomerService : IService<CustomerInfo>
	{
		public SQLiteAsyncConnection con;
		string _dbPath;
		
		// Constructor
		public CustomerService(string dbPath)
		{
			_dbPath = dbPath;
		}

		/*
		 * Initializes connection to database if needed
		 * and creates customerinfo table if it doesn't exist
		 */
		private async Task InitAsync()
		{
			if (con != null)
			{
				return;
			}
			con = new SQLiteAsyncConnection(_dbPath);
			await con.CreateTableAsync<CustomerInfo>();
		}

		/*
		 * AddUpdateXAsync method
		 * 
		 * adds customerinfo object to database if new record, else updates existing record
		 * 
		 * @param - customerinfo object
		 * @return - bool, true if task completed
		 */
		public async Task<bool> AddUpdateXAsync(CustomerInfo customerInfo)
		{
			if (customerInfo.Id > 0)
			{
				await con.UpdateAsync(customerInfo);
			}
			else
			{
				await con.InsertAsync(customerInfo);
			}

			return await Task.FromResult(true);
		}

		/*
		 * DeleteXAsync method
		 * 
		 * checks database of customerinfo objects for entry with matching id value
		 * and deletes entry
		 * 
		 * @param - int customer id number
		 * @return - bool, true if task completed
		 */
		public async Task<bool> DeleteXAsync (int customerNum)
		{
			await con.DeleteAsync<CustomerInfo>(customerNum);
			return await Task.FromResult(true);
		}

		/*
		 * GetXAsync method
		 * 
		 * checks database of customerinfo object for entry with matching id value
		 * and returns entry
		 * 
		 * @param - int customer id number
		 * @return - customerinfo object
		 */
		public async Task<CustomerInfo> GetXAsync(int customerNum)
		{
			return await con.Table<CustomerInfo>().Where(p => p.Id == customerNum).FirstOrDefaultAsync();
		}

		/*
		 * GetXAsync method
		 * 
		 * checks database of customerinfo objects 
		 * and returns all entries
		 * 
		 * @param - none
		 * @return - ienumerate of all customerinfo objects
		 */
		public async Task<IEnumerable<CustomerInfo>> GetXAsync()
		{
			await InitAsync();
			return await Task.FromResult(await con.Table<CustomerInfo>().ToListAsync());
		}
	}
}
