using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vulkan2Blazor.Models.ClanAttributes;

public class Delo
{
    public int DeloId { get; set; }
    
    [Required]
    [ForeignKey("Clan")]
    public int ClanId { get; set; }
    
    public virtual Clan Clan { get; set; }
    
    [Required]
    public string VrstaDela { get; set; }
    
    [Required]
    public DateOnly Datum { get; set; }
    
    [Required]
    [Range(0.01, float.MaxValue, ErrorMessage = "Stevilo ur mora biti pozitivno stevilo.")]
    public float SteviloUr { get; set; }
    
}