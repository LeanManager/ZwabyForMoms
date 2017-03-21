using System;
using SQLite;

namespace ZwabyBeta
{
	public class Customer
	{
		// RegistrationStatus changes based on phone verification.

		private bool registrationStatus;
		public bool RegistrationStatus
		{
			get { return registrationStatus; }
			set { registrationStatus = value; }
		}

		[PrimaryKey, AutoIncrement]
		public int CustomerId
		{
			get;
			set;
		}

		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string address;
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private double phoneNumber;
		public double PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		private string emailAddress;
		public string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}
	}
}
