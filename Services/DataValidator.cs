using System.Text.RegularExpressions;

namespace FinalOOProject.Services
{
	public class DataValidator
	{
		/* 
		 * Encapsulates all entry validation functions
		 * Author: James Sundby, Connor DeHaas
		 */

		/*
		 * CheckBooKEntry method
		 * 
		 * checks validity of entered book values, throws an exception and displays
		 * error message for user if check condition fails
		 * 
		 * @param - string name = entered book name 
		 * @param - string author = entered book author
		 * @param - string quality = entered book quality
		 * @param - string tags = entered book tags
		 * @param - string enteredCostStr = entered book cost, as string to allow for decimal check
		 * 
		 * @return - bool, true if all conditions true
		 */
		public static bool CheckBookEntry(string name, string author, string quality, string tags, string enteredCostStr)
		{
			try
			{
				// Null or white space checks
				if (string.IsNullOrWhiteSpace(name))
				{
					throw new Exception("Please enter the book's name.");
				}
				if (string.IsNullOrWhiteSpace(author))
				{
					throw new Exception("Please enter the book's author.");
				}
				if (string.IsNullOrWhiteSpace(quality))
				{
					throw new Exception("Please enter the book's quality.");
				}
				if (string.IsNullOrWhiteSpace(tags))
				{
					throw new Exception("Please enter at least one book tag.");
				}

				// Price checks
				if (!decimal.TryParse(enteredCostStr, out decimal cost))
				{
					throw new Exception("Please enter a valid decimal value for the cost.");
				}
				decimal bookCost = decimal.Parse(enteredCostStr);
				if (bookCost <= 0)
				{
					throw new Exception("Please enter a value greater than 0 for the cost.");
				}
			}
			catch (Exception ex)
			{
				App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
				return false;
			}
			return true;
		}

		/*
		 * CheckCustomerEntry method
		 * 
		 * checks validity of entered customer values, throws an exception and displays
		 * error message for user if check condition fails
		 * 
		 * @param - string name = entered customer name 
		 * @param - string city = entered city of residence
		 * @param - string state = entered province of residence
		 * @param - string country = entered country of residence
		 * @param - string zip_code = entered customer postal code
		 * @param - string address = entered customer street address
		 * @param - string email = entered customer email
		 * @param - string phone_number = entered customer phone number
		 * 
		 * @return - bool, true if all conditions true
		 */
		public static bool CheckCustomerEntry(string name, string city, string address, string state, string country, string zip_code, string email, string phone_number)
		{
			Regex postalRx = new Regex(@"[A-Z][0-9][A-Z][\s][0-9][A-Z][0-9]");
			Regex emailRx = new Regex(@"\w+[@]\w+[.]\w+");
			Regex phoneRx = new Regex(@"^\d{11}$");
			string listProv = "AB,BC,MB,NB,NL,NS,NT,NU,ON,PE,QC,SK,YT";
			string checkCountry = "Canada";

			try
			{
				//Null or empty checks
				if (string.IsNullOrWhiteSpace(name))
				{
					throw new Exception("Please enter the customer's name.");
				}
				if (string.IsNullOrWhiteSpace(city))
				{
					throw new Exception("Please enter the city where the customer lives.");
				}
				if (string.IsNullOrWhiteSpace(address))
				{
					throw new Exception("Please enter the customer's street address.");
				}
				if (string.IsNullOrWhiteSpace(state))
				{
					throw new Exception("Please enter the province where the customer lives.");
				}
				if (string.IsNullOrWhiteSpace(country))
				{
					throw new Exception("Please enter the country where the customer lives.");
				}
				if (string.IsNullOrWhiteSpace(zip_code))
				{
					throw new Exception("Please enter the customer's postal code.");
				}
				if (string.IsNullOrWhiteSpace(email))
				{
					throw new Exception("Please enter the customer's email.");
				}
				if (string.IsNullOrWhiteSpace(phone_number))
				{
					throw new Exception("Please enter the customer's phone number.");
				}
				
				//Regex checks
				if (!postalRx.IsMatch(zip_code))
				{
					throw new Exception("Postal code must be in the format of A1A 1A1");
				}
				if (!emailRx.IsMatch(email))
				{
					throw new Exception("Email must be in the correct format. Example: example@site.com");
				}
				if (!phoneRx.IsMatch(phone_number))
				{
					throw new Exception("Phone number must be in the correct format. Example: 14149963514");
				}

				//Canadian address checks
				if (!listProv.Contains(state.ToUpper()))
				{
					throw new Exception("Entered province must be in list of Canadian abbreviations.");
				}
				if (!checkCountry.ToUpper().Contains(country.ToUpper()))
				{
					throw new Exception("Customer must have a valid Canadian address.");
				}

			}
			catch (Exception ex)
			{
				App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
				return false;
			}
			return true;
		}

		/*
		 * CheckStaffEntry method
		 * 
		 * checks validity of entered staff values, throws an exception and displays
		 * error message for user if check condition fails
		 * 
		 * @param - string name = entered staff first name 
		 * @param - string lname = entered staff last name
		 * @param - string email = entered staff email address
		 * @param - string phone_number = entered staff phone number
		 * 
		 * @return - bool, true if all conditions true
		 */
		public static bool CheckStaffEntry(string name, string lname, string phone, string email)
		{
			Regex emailRx = new Regex(@"\w+[@]\w+[.]\w+");
			Regex phoneRx = new Regex(@"^\d{11}$");

			try
			{
				// Null or empty checks
				if (string.IsNullOrWhiteSpace(name))
				{
					throw new Exception("Please enter the staff member's first name.");
				}
				if (string.IsNullOrWhiteSpace(lname))
				{
					throw new Exception("Please enter the staff member's last name.");
				}
				if (string.IsNullOrWhiteSpace(phone))
				{
					throw new Exception("Please enter the staff member's phone number.");
				}
				if (string.IsNullOrWhiteSpace(email))
				{
					throw new Exception("Please enter the staff member's email address.");
				}
				
				//Regex checks
				if (!phoneRx.IsMatch(phone))
				{
					throw new Exception("Phone number must be in the correct format. Example: 14149963514");
				}
				if (!emailRx.IsMatch(email))
				{
					throw new Exception("Email must be in the correct format. Example: example@site.com");
				}
			}
			catch (Exception ex)
			{
				App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
				return false;
			}

			return true;
		}
	}
}
