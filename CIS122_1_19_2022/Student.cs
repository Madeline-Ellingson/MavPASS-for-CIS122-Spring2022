using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_1_19_2022
{
	public class Student
	{
		// *** Class variables aka private variables ***

		// always be atomic, i.e. can you break name into pieces?
		// Don't use something that could be true
		private int studentId = -1;
		private string firstName = "default first name";
		private string lastName = "n/a";

		// always pick the worst choice, not the most restrictive choice
		private bool isInternational = false;
		private string ssn = "n/a";

		// in reality we would not track fees in this class, it is just so
		// we can show a double data type
		private double feeBalance = 0.0;

		// Don't use calculated fields (variables) as private variables
		private string birthDate = "1/1/1700";

		// people can have more than 1 email, so maybe this should be an array or list?
		// or you could just have them input their primary email
		private List<string> emails = new List<string>();

		// *** Gets & Sets ***
		// also knows as accessor methods
		public int StudentID
		{
			get
			{
				return this.studentId;
			}
			// Student ID cannot be changed
			// This is Read Only

			//set
			//{
			//	this.studentId = value;
			//}
		}

		public string FirstName
		{
			get
			{
				return this.firstName;
			}

			set
			{
				this.firstName = value;
			}
		}
		public string LastName
		{
			get
			{
				return this.lastName;
			}

			set
			{
				this.lastName = value;
			}
		}

		public string FullName
		{
			get
			{
				return this.firstName + ", " + this.lastName;
			}
		}

		public bool IsInternational
		{
			get
			{
				return this.isInternational;
			}

			set
			{
				this.isInternational = value;
			}
		}


		// You should not be able to print out someone's
		// ssn. It is confidential

		// This is a Write Only field
		public string SSN
		{
			//get
			//{
			//	return this.ssn;
			//}

			set
			{
				this.ssn = value;
			}
		}
		public double FeeBalance
		{
			get
			{
				return this.feeBalance;
			}

			set
			{
				// You can put logic in gets and sets
				// you can put all kinds of loops, if statements,
				// function calls etc. in gets/sets
				// in this case we are saying fee balance cannot be less than 0.0
				if(value >= 0.0)
				{
					this.feeBalance = value;
				}
				else
				{
					this.feeBalance = 0.0;
				}

			}
		}
		public string BirthDate
		{
			get
			{
				return this.birthDate;
			}

			set
			{
				this.birthDate = value;
			}
		}
		public List<string> Emails
		{
			get
			{
				return this.emails;
			}

			set
			{
				this.emails = value;
			}
		}

		// Methods

		// *** To String Method ***
		// This method makes an easy way to display our objects
		public override string ToString()
		{
			// Create a new message
			string message = "";

			// Concatinate each thing you want to display into the message
			message += "Student ID: " + this.StudentID + "\n"
				+ "First Name: " + this.FirstName + "\n"
				+ "Last Name: " + this.LastName + "\n"
				+ "Fee Balance: " + this.FeeBalance + "\n"
				+ "Is International: " + this.IsInternational + "\n"
				+ "Full Name: " + this.FullName + "\n";

			// Return the message
			return message;
		}
	}
}
