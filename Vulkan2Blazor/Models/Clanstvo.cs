using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace Vulkan2Blazor.Models;

public class Clanstvo
{
    public int ClanstvoId { get; set; }
    
    [Required]
    [ForeignKey("Clan")]
    public int ClanId { get; set; }
    
    public virtual Clan Clan { get; set; }
    
    [Required]
    [ForeignKey("GasilskoDrustvo")]
    public int GasilskoDrustvoId { get; set; }
    
    public virtual GasilskoDrustvo GasilskoDrustvo { get; set; }
    
    [Required]
    public DateOnly OdDatum { get; set; }
    
    [Required]
    public DateOnly? DoDatum { get; set; }
}