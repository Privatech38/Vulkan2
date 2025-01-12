using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vulkan2Blazor.Models;
using Vulkan2Blazor.Models.ClanAttributes;

namespace Vulkan2Blazor.Data
{
    public class Vulkan2Context : IdentityDbContext<ApplicationUser>
    {
        public Vulkan2Context (DbContextOptions<Vulkan2Context> options)
            : base(options)
        {
        }

        public DbSet<Vulkan2Blazor.Models.Clan> Clan { get; set; } = default!;
        public DbSet<Vulkan2Blazor.Models.GasilskoDrustvo> GasilskoDrustvo { get; set; } = default!;
        public DbSet<Vulkan2Blazor.Models.GasilskaZveza> GasilskaZveza { get; set; } = default!;
        public DbSet<Vulkan2Blazor.Models.ClanAttributes.ZdravstveniPregled> ZdravstveniPregled { get; set; } = default!;
    }
}
