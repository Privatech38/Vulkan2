using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vulkan2Blazor.Models;

public enum CinType
{
    [Display(Name = "Pionir")]
    Pionir,
    [Display(Name = "Mladinec")]
    Mladinec,
    [Display(Name = "Pripravnik")]
    Pripravnik,
    [Display(Name = "Gasilec")]
    Gasilec,
    [Display(Name = "Gasilec I. stopnje")]
    GasilecIStopnje,
    [Display(Name = "Gasilec II. stopnje")]
    GasilecIiStopnje,
    [Display(Name = "Višji gasilec")]
    VisjiGasilec,
    [Display(Name = "Višji gasilec I. stopnje")]
    VisjiGasilecIStopnje,
    [Display(Name = "Višji gasilec II. stopnje")]
    VisjiGasilecIIStopnje,
    [Display(Name = "nižji gasilski častnik")]
    NizjiCastnik,
    [Display(Name = "nižji gasilski častnik I. stopnje")]
    NizjiCastnikIStopnje,
    [Display(Name = "nižji gasilski častnik II. stopnje")]
    NizjiCastnikIIStopnje,
    [Display(Name = "Gasilski častnik")]
    Castnik,
    [Display(Name = "Gasilski častnik I. stopnje")]
    CastnikIStopnje,
    [Display(Name = "Gasilski častnik II. stopnje")]
    CastnikIiStopnje,
    [Display(Name = "Višji gasilski častnik")]
    VisjiCastnik,
    [Display(Name = "Višji gasilski častnik I. stopnje")]
    VisjiCastnikIStopnje,
    [Display(Name = "Višji gasilski častnik II. stopnje")]
    VisjiCastnikIIStopnje,
    [Display(Name = "Visoki gasilski častnik")]
    VisokiCastnik,
    [Display(Name = "Visoki gasilski častnik I. stopnje")]
    VisokiCastnikIStopnje,
    [Display(Name = "Visoki gasilski častnik II. stopnje")]
    VisokiCastnikIIStopnje,
    // Organizacijske vede
    [Display(Name = "Višji častnik organizacijske smeri")]
    VisjiCastnikOrganizacijskeSmeri,
    [Display(Name = "Višji častnik organizacijske smeri I. stopnje")]
    VisjiCastnikOrganizacijskeSmeriIStopnje,
    [Display(Name = "Višji častnik organizacijske smeri II. stopnje")]
    VisjiCastnikOrganizacijskeSmeriIIStopnje,
    [Display(Name = "Visoki častnik organizacijske smeri")]
    VisokiCastnikOrganizacijskeSmeri,
    [Display(Name = "Visoki častnik organizacijske smeri I. stopnje")]
    VisokiCastnikOrganizacijskeSmeriIStopnje,
    [Display(Name = "Visoki častnik organizacijske smeri II. stopnje")]
    VisokiCastnikOrganizacijskeSmeriIIStopnje
}

public class Cin
{
    public int CinId { get; set; }
    
    [Required]
    public CinType CinType { get; set; }
    
    [Required]
    public DateOnly OdDatum { get; set; }
    
    [Required]
    public Clan Clan { get; set; }
}