using Microsoft.AspNetCore.Identity;

namespace BlazorWebApp.Data;

// Add profile data for  users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string? ProfilePicture { get; set; }
	public string? Biography { get; set; }
	public string? UserProfileId { get; set; }
	public string? UserAddressId { get; set; }
	public UserAddress? UserAddress { get; set; }
}
