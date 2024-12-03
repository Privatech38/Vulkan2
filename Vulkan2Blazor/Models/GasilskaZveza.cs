namespace Vulkan2Blazor.Models;

public class GasilskaZveza
{
    public int GasilskaZvezaId { get; set; }
    
    public ICollection<GasilskoDrustvo> GasilskaDrustva { get; }
    
}