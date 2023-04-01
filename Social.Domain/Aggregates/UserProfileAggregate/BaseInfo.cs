namespace Social.Domain.Aggregates.UserProfileAggregate;

public class BasicInfo
{
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	public string EmailAddress { get; private set; }
	public string Phone { get; private set; }
	public DateTime DateOfBirth { get; private set; }
	public string CurrentCity { get; private set; }
	public static BasicInfo CreateBasicInfo(string FirstName, string LastName, string emalAddress
, string phone, DateTime dateOfBirth, string currentCity)
}
