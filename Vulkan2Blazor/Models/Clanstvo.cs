namespace Vulkan2Blazor.Models;

public class Clanstvo
{
    public int ClanstvoId { get; set; }
    
    public Clan Clan { get; set; }
    public GasilskoDrustvo GasilskoDrustvo { get; set; }
    
    public DateOnly OdDatum { get; set; }
    public DateOnly DoDatum { get; set; }
    
    public bool Aktiven { get; set; }
    public string Polozaj { get; set; }
    
}