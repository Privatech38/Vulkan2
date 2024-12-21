using Microsoft.Build.Framework;

namespace Vulkan2Blazor.Models;

public class Clanstvo
{
    public int ClanstvoId { get; set; }
    
    [Required]
    public Clan Clan { get; set; }
    
    [Required]
    public GasilskoDrustvo GasilskoDrustvo { get; set; }
    
    [Required]
    public DateOnly OdDatum { get; set; }
    
    [Required]
    public DateOnly? DoDatum { get; set; }
}