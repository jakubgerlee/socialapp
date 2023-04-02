﻿namespace Social.Domain.Aggregates.UserProfileAggregate;

public class UserProfile
{
	private UserProfile()
	{

	}

	public Guid UserProfileId { get; private set; }
	public string IdentityId { get; private set; } //foregin key
	public BasicInfo BasicInfo { get; private set; }
	public DateTime DateCreated { get; private set; }
	public DateTime LastModified { get; private set; }

	// Factory method
	public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
	{
		// TODO: Add validation, error handling strategies,and error notificion strategies


		return new UserProfile
		{
			IdentityId = identityId,
			BasicInfo = basicInfo,
			DateCreated = DateTime.UtcNow,
			LastModified = DateTime.UtcNow
		};
	}

	// Public methods
	public void UpdateBasicInfo(BasicInfo newInfo)
	{
		BasicInfo = newInfo;
		LastModified = DateTime.UtcNow;
	}
}
