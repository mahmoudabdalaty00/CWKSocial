﻿namespace CWK.Domain.Aggregates.UserPofile
{
	public class BasicInfo
	{

		private BasicInfo()
		{

		}
		public string FirstName { get; private set; }
		public string LastName { get; private set; }

		public string EmailAddress { get; private set; }
		public string Phone { get; private set; }

		public DateTime DateOfBirth { get; private set; }
		public string CurrentCity { get; private set; }

		public static BasicInfo CreateBasicInfo(
			string firstName, string lastName
			, string emailAddress, string phone,
			DateTime dateOfBirth, string currentCity)
		{

			BasicInfo basicInfo = new BasicInfo
			{
				FirstName = firstName,
				LastName = lastName,
				EmailAddress = emailAddress,
				Phone = phone,
				DateOfBirth = dateOfBirth,
				CurrentCity = currentCity
			};

			// To Add Validation Error Handling strategies ,Error Notification strategies

			return basicInfo;
		}


	}
}
