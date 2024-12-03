using Microsoft.EntityFrameworkCore;

namespace Vulkan2Blazor;

public class Vulkan2BlazorContext : DbContext
{
    public Vulkan2BlazorContext(DbContextOptions<Vulkan2BlazorContext> options)
        : base(options)
    {
    }
}