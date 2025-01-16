using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Vulkan2Blazor.Data;
using Vulkan2Blazor.Models;

namespace Vulkan2Blazor.Seeders
{
    public static class GasilskoDrustvoSeeder
    {
        public static async Task SeedGasilskoDrustvo(IServiceProvider serviceProvider)
        {
            using var context = new Vulkan2Context(
                serviceProvider.GetRequiredService<DbContextOptions<Vulkan2Context>>());

            if (await context.GasilskoDrustvo.AnyAsync())
            {
                return; // DB has been seeded
            }

            context.GasilskoDrustvo.AddRange(
                new GasilskoDrustvo
                {
                    Naziv = "Prostovoljno gasilsko društvo Mavčiče",
                    Naslov = "Mavčiče 69",
                    Posta = "4211",
                    Kraj = "Mavčiče",
                    Email = "info@pgd-mavcice.si",
                    Telefon = "041 337 236",
                    SpletnaStran = "https://www.pgd-mavcice.si",
                    MaticnaStevilka = "5155606000",
                    DavcnaStevilka = "71126945",
                    GasilskaZvezaId = context.GasilskaZveza.Single(gz => gz.Naziv == "Gasilska zveza mestne občine Kranj").GasilskaZvezaId
                },
                new GasilskoDrustvo
                {
                    Naziv = "Prostovoljno gasilsko društvo Breg ob Savi",
                    Naslov = "Breg ob Savi 34",
                    Posta = "4211",
                    Kraj = "Mavčiče",
                    Email = "info@pgd-bregobsavi.si",
                    Telefon = "051 631 238",
                    SpletnaStran = "https://www.pgd-bregobsavi.si",
                    MaticnaStevilka = "5129001123",
                    DavcnaStevilka = "73796590",
                    GasilskaZvezaId = context.GasilskaZveza.Single(gz => gz.Naziv == "Gasilska zveza mestne občine Kranj").GasilskaZvezaId
                }
            );

            await context.SaveChangesAsync();
        }
    }
}