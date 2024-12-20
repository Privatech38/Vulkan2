using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models.ClanAttributes;

public class ZdravstveniPregled
{
    public int ZdravstveniPregledId { get; set; }
    
    [Required]
    public Clan Clan { get; set; }
    
    [Required]
    public DateOnly Datum { get; set; }
    
    public DateOnly? VeljavnoDo { get; set; }
    
    public string? Opombe { get; set; }
    
}