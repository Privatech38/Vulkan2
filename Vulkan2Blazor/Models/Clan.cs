using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models;

public class Clan
{
    public int ClanId { get; set; }
    
    public string Ime { get; set; }
    
    public string Priimek { get; set; }
    
    public DateOnly DatumRojstva { get; set; }
    
    public string? Spol { get; set; }
    
    public string EMSO { get; set; }
    
    // Drustvo
    public GasilskoDrustvo GasilskoDrustvo { get; set; }
    
    // Cini
    public ICollection<Cin> Cini { get; }
    
    // Članstva
    public ICollection<Clanstvo> Clanstva { get; }
    
    // Kontakt
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    
    [DataType(DataType.PhoneNumber)]
    public string? Telefon { get; set; }
    
}