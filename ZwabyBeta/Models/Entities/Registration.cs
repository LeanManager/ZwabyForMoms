using System;
namespace ZwabyBeta
{
	public class Registration
	{
		private bool registrationStatus;

		public bool RegistrationStatus
		{
			get { return registrationStatus; }
			set { registrationStatus = value; }
		}

		public Registration()
		{
			RegistrationStatus = true;
		}

		//public static bool GetRegistrationStatus(int registrationId)
		//{
		//	bool status = new bool();

		//	if (status == true)
		//	{
		//		// Main Navigation
		//	}
		//	else
		//	{
		//		// Registration Navigation
		//	}


	}
}
