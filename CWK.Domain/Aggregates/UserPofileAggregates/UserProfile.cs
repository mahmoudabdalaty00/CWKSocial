namespace CWK.Domain.Aggregates.UserPofile
{
	public class UserProfile
	{

		private UserProfile()
        {
            
        }
        public Guid UserProfileId { get;private set; }

		public string IdentityId { get; private set; }

		public BasicInfo BasicInfo { get; private set; }

		public DateTime DateCreated { get; private set; }
		public DateTime LastModified { get; private set; }

		//Factory Method
		public static UserProfile CreateUserProfile (string identityId , BasicInfo basicInfo)
		{
			var user = new UserProfile
			{
				IdentityId = identityId ,
				BasicInfo = basicInfo,
				DateCreated = DateTime.UtcNow ,
				LastModified = DateTime.UtcNow,

			};

			// To Add Validation Error Handling strategies ,Error Notification strategies

			return user;
		}
		//public Method 
		public void UpdateBasicInfo( BasicInfo newinfo)
		{
			BasicInfo = newinfo;
			LastModified = DateTime.UtcNow;

		}

	}
}
