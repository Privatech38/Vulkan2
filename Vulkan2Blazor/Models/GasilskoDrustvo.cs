using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models;

public enum TipDrustva
{
    Teritorialno,
    Industrijsko
}

public class GasilskoDrustvo
{
    public int GasilskoDrustvoId { get; set; }
    
    [Required]
    public TipDrustva TipDrustva { get; set; }
    
    // Naslov
    [Required]
    public string Naslov { get; set; }
        
    [Required]
    [RegularExpression(@"^\d{4}$", ErrorMessage = "Poštna številka mora biti dolga točno 4 števke.")]
    public string Posta { get; set; }
        
    [Required]
    public string Kraj { get; set; }
    
    // Kontakt
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string? Email { get; set; }
    
    [DataType(DataType.PhoneNumber)]
    [Phone]
    public string? Telefon { get; set; }
    
    [DataType(DataType.Url)]
    [Url]
    public string? SpletnaStran { get; set; }
    
    // Podatki
    [Required]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Matična številka mora biti dolga točno 10 števk.")]
    public string MaticnaStevilka { get; set; }
        
    [Required]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Davčna številka mora biti dolga točno 8 števk.")]
    public string DavcnaStevilka { get; set; }
    
    public GasilskaZveza GasilskaZveza { get; set; }
    
    
}