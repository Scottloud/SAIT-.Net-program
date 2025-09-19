using FinalOOProject.Data;
using SQLite;


namespace FinalOOProject.Services
{

	public class StaffService : IService<StaffInfo>
	{
		/* 
		 * Framework to create a new StaffService object
		 * Author: Scott Louden
		 */
		public SQLiteAsyncConnection con;
		string _dbPath;

		// Constructor
		public StaffService(string dbPath)
		{
			_dbPath = dbPath;
		}

		/*
		 * Initializes connection to database if needed
		 * and creates staffinfo table if it doesn't exist
		 */
		private async Task InitAsync()
		{
			if (con != null)
			{
				return;
			}
			con = new SQLiteAsyncConnection(_dbPath);
			await con.CreateTableAsync<StaffInfo>();
		}

		/*
		* AddUpdateXAsync method
		* 
		* adds staffinfo object to database if new record, else updates existing record
		* 
		* @param - staffinfo object
		* @return - bool, true if task completed
		*/
		public async Task<bool> AddUpdateXAsync(StaffInfo staffInfo)
		{
			
			if (staffInfo.Id > 0)
			{
				await con.UpdateAsync(staffInfo);
			}
			else
			{
				await con.InsertAsync(staffInfo);
			}
			return await Task.FromResult(true);
		}

		/*
		* DeleteXAsync method
		* 
		* checks database of staffinfo object for entry with matching id value
		* and deletes entry
		* 
		* @param - int staff id number
		* @return - bool, true if task completed
		*/
		public async Task<bool> DeleteXAsync(int staffID)
		{
			await con.DeleteAsync<StaffInfo>(staffID);
			return await Task.FromResult(true);
		}

		/*
		* GetXAsync method
		* 
		* checks database of staffinfo object for entry with matching id value
		* and returns entry
		* 
		* @param - int staff id number
		* @return - staffinfo object
		*/
		public async Task<StaffInfo> GetXAsync(int staffID)
		{
			return await con.Table<StaffInfo>().Where(p => p.Id == staffID).FirstOrDefaultAsync();
		}

		/*
		 * GetXAsync method
		 * 
		 * checks database of staffinfo objects 
		 * and returns all entries
		 * 
		 * @param - none
		 * @return - ienumerate of all staffinfo objects
		 */
		public async Task<IEnumerable<StaffInfo>> GetXAsync()
		{
			await InitAsync();
			return await Task.FromResult(await con.Table<StaffInfo>().ToListAsync());
		}

	}
}

