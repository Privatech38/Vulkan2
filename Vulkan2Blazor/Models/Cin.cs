namespace Vulkan2Blazor.Models;

public class Cin
{
    public int CinId { get; set; }
    
    public DateOnly OdDatum { get; set; }
    public DateOnly? DoDatum { get; set; }
    
    public Clan Clan { get; set; }
}