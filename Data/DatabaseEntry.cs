using SQLite;

namespace FinalOOProject.Data
{
	/* 
	 * Framework to create a base BasicDatabaseEntry object
	 * Author: James Sundby
	 */
	public class BasicDatabaseEntry
	{
		/*
		 * Getters and Setters
		 * 
		 * Getters
		 * @param - no parameter
		 * @return - value of specified variable
		 * 
		 * Setters
		 * @param - value to update specified variable
		 * @return - no return
		 */
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
