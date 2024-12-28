using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vulkan2Blazor.Models;

namespace Vulkan2Blazor.Data
{
    public class Vulkan2Context : IdentityDbContext<ApplicationUser>
    {
        public Vulkan2Context (DbContextOptions<Vulkan2Context> options)
            : base(options)
        {
        }

        public DbSet<Vulkan2Blazor.Models.Clan> Clan { get; set; } = default!;
    }
}