using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Vulkan2Blazor.Models;

namespace Vulkan2Blazor.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [ForeignKey("Clan")]
    public int? ClanId { get; set; }
    
    public virtual Clan? Clan { get; set; }
}