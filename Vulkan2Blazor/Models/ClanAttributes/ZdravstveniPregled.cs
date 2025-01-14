using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vulkan2Blazor.Models.ClanAttributes;

public class ZdravstveniPregled
{
    public int ZdravstveniPregledId { get; set; }
    
    [Required]
    [ForeignKey("Clan")]
    public int ClanId { get; set; }
    
    public virtual Clan Clan { get; set; }
    
    [Required]
    public DateOnly Datum { get; set; }
    
    public DateOnly? VeljavnoDo { get; set; }
    
    public string? Opombe { get; set; }
    
}