using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models;

public class GasilskaZveza
{
    public int GasilskaZvezaId { get; set; }
    
    [Required]
    public string Naziv { get; set; }
    
    // Naslov
    [Required]
    public string Naslov { get; set; }
    
    [Required]
    [DisplayName("Poštna številka")]
    [RegularExpression(@"^\d{4}$", ErrorMessage = "Poštna številka mora biti dolga točno 4 števke.")]
    public string Posta { get; set; }
    
    [Required]
    public string Kraj { get; set; }
    
    // Kontakt
    [EmailAddress]
    public string? Email { get; set; }
    
    [Phone]
    public string? Telefon { get; set; }
    
    [Url]
    [DisplayName("Spletna stran")]
    public string? SpletnaStran { get; set; }
    
    // Podatki
    [Required]
    [DisplayName("Matična številka")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Matična številka mora biti dolga točno 10 števk.")]
    public string MaticnaStevilka { get; set; }
        
    [Required]
    [DisplayName("Davčna številka")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Davčna številka mora biti dolga točno 8 števk.")]
    public string DavcnaStevilka { get; set; }
    
    public virtual ICollection<GasilskoDrustvo> GasilskaDrustva { get; }
    
}