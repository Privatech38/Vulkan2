﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vulkan2Blazor.Models.ClanAttributes;

namespace Vulkan2Blazor.Models;

public enum Spol {
    Moski,
    Zenska
}

public class Clan
{
    public int ClanId { get; set; }
    
    [Required]
    public string Ime { get; set; }
    
    [Required]
    public string Priimek { get; set; }
    
    [Required]
    public DateOnly DatumRojstva { get; set; }
    
    [Required]
    public Spol Spol { get; set; }
    
    [Required]
    [RegularExpression(@"^\d{13}$", ErrorMessage = "EMŠO mora biti dolgo točno 13 števk.")]
    public string EMSO { get; set; }
    
    // Drustvo
    [Required]
    [ForeignKey("GasilskoDrustvo")]
    public int GasilskoDrustvoId { get; set; }
    
    public virtual GasilskoDrustvo GasilskoDrustvo { get; set; }
    
    // Cini
    public ICollection<Cin> Cini { get; }
    
    // Članstva
    public ICollection<Clanstvo> Clanstva { get; }
    
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
    
    // Podatki
    
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Davčna številka mora biti dolga točno 8 števk.")]
    public string? DavcnaStevilka { get; set; }
    
    public ICollection<Delo> OpravljenoDelo { get; }
    
    public ICollection<ZdravstveniPregled> ZdravstveniPregledi { get; }
    
}