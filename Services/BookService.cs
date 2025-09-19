using FinalOOProject.Data;
using SQLite;

namespace FinalOOProject.Services
{
	/* 
	 * Framework to create a new BookService object
	 * Author: James Sundby
	 */
	public class BookService : IService<BookInfo>
	{
		public SQLiteAsyncConnection con;
		string _dbPath;

		// Constructor
		public BookService(string dbPath)
		{
			_dbPath = dbPath;
		}

		/*
		 * Initializes connection to database if needed
		 * and creates bookinfo table if it doesn't exist
		 */
		private async Task InitAsync()
		{
			if (con != null)
			{
				return;
			}
			con = new SQLiteAsyncConnection(_dbPath);
			await con.CreateTableAsync<BookInfo>();
		}

		/*
		 * AddUpdateXAsync method
		 * 
		 * adds bookinfo object to database if new record, else updates existing record
		 * 
		 * @param - bookinfo object
		 * @return - bool, true if task completed
		 */
		public async Task<bool> AddUpdateXAsync(BookInfo bookInfo)
		{
			if (bookInfo.Id > 0)
			{
				await con.UpdateAsync(bookInfo);
			}
			else
			{
				await con.InsertAsync(bookInfo);
			}
			return await Task.FromResult(true);
		}

		/*
		 * DeleteXAsync method
		 * 
		 * checks database of bookinfo object with matching id value
		 * and deletes entry
		 * 
		 * @param - int bookId number
		 * @return - bool, true if task completed
		 */
		public async Task<bool> DeleteXAsync(int bookId)
		{
			await con.DeleteAsync<BookInfo>(bookId);
			return await Task.FromResult(true);
		}

		/*
		 * GetXAsync method
		 * 
		 * checks database of bookinfo object for entry with matching id value
		 * and returns entry
		 * 
		 * @param - int bookId number
		 * @return - bookinfo object
		 */
		public async Task<BookInfo> GetXAsync(int bookId)
		{
			return await con.Table<BookInfo>().Where(p => p.Id == bookId).FirstOrDefaultAsync();
		}

		/*
		 * GetXAsync method
		 * 
		 * checks database of bookinfo objects 
		 * and returns all entries
		 * 
		 * @param - 
		 * @return - ienumerate of all bookinfo object
		 */
		public async Task<IEnumerable<BookInfo>> GetXAsync()
		{
			await InitAsync();
			return await Task.FromResult(await con.Table<BookInfo>().ToListAsync());
		}

		/*
		 * LendBookAsync method
		 * 
		 * checks value of bookinfo's booklentout and flips it between
		 * 1 and 0, then updates database entry
		 * 
		 * @param - bookinfo
		 * @return - bool, true if task complete
		 */
		public async Task<bool> LendBookAsync(BookInfo bookInfo)
        {
            if (bookInfo.BookLentOut == 0)
            {
				bookInfo.BookLentOut = 1;
                await con.UpdateAsync(bookInfo);
            }
            else
            {
				bookInfo.BookLentOut = 0;
                await con.UpdateAsync(bookInfo);
            }
			return await Task.FromResult(true);
        }
    }
}
