using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models.ClanAttributes;

public class Delo
{
    public int DeloId { get; set; }
    
    [Required]
    public Clan Clan { get; set; }
    
    [Required]
    public string VrstaDela { get; set; }
    
    [Required]
    public DateOnly Datum { get; set; }
    
    [Required]
    public float SteviloUr { get; set; }
    
}