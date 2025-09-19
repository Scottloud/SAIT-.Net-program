namespace FinalOOProject.Data
{
	/* 
	 * Framework to create a StaffInfo object
	 * Author: Scott Louden
	 */
	public class StaffInfo : BasicDatabaseEntry
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
		public string StaffLname { get; set; }
		public string StaffEmail { get; set; }
		public string Number { get; set; }


	}
}
