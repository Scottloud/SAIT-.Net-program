namespace FinalOOProject.Data
{
	/* 
	 * Framework to create a new BookInfo object
	 * Author: James Sundby
	 */
	public class BookInfo : BasicDatabaseEntry
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
		 * 
		 */

		public string BookAuthor { get; set; }
		public decimal BookCost { get; set; }
		public string BookQuality { get; set; }
		public int BookLentOut { get; set; }
		public string BookDesc { get; set; }
		public string BookTags { get; set; }
		


	}
}
