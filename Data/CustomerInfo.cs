namespace FinalOOProject.Data
{
	/* 
	 * Framework to create a new CustomerInfo object
	 * Author: Connor DeHaas
	 */
	public class CustomerInfo : BasicDatabaseEntry
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
		public string Address { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string ZipCode { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		
	}
}
