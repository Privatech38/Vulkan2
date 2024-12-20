using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models;

public class GasilskaZveza
{
    public int GasilskaZvezaId { get; set; }
    
    public string Naziv { get; set; }
    
    // Naslov
    public string? Naslov { get; set; }
    
    public string? Posta { get; set; }
    
    public string? Kraj { get; set; }
    
    // Kontakt
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    
    [DataType(DataType.PhoneNumber)]
    public string? Telefon { get; set; }
    
    [DataType(DataType.Url)]
    public string? SpletnaStran { get; set; }
    
    // Podatki
    public string? MaticnaStevilka { get; set; }
    
    public string? DavcnaStevilka { get; set; }
    
    
    public ICollection<GasilskoDrustvo> GasilskaDrustva { get; }
    
}