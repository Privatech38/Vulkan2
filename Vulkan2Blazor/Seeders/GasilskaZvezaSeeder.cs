using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Vulkan2Blazor.Data;
using Vulkan2Blazor.Models;

namespace Vulkan2Blazor.Seeders
{
    public static class GasilskaZvezaSeeder
    {
        public static async Task SeedGasilskaZveza(IServiceProvider serviceProvider)
        {
            using var context = new Vulkan2Context(
                serviceProvider.GetRequiredService<DbContextOptions<Vulkan2Context>>());

            if (await context.GasilskaZveza.AnyAsync())
            {
                return; // DB has been seeded
            }

            context.GasilskaZveza.AddRange(
                new GasilskaZveza
                {
                    Naziv = "Gasilska zveza mestne občine Kranj",
                    Naslov = "Bleiweisova cesta 34",
                    Posta = "4000",
                    Kraj = "Kranj",
                    Email = "gzmo.kranj@gmail.com",
                    Telefon = "04 201 24 22",
                    SpletnaStran = "https://gzmo-kranj.si/",
                    MaticnaStevilka = "1167618000",
                    DavcnaStevilka = "34929703"
                },
                new GasilskaZveza
                {
                    Naziv = "Gasilska Zveza Ljubljana",
                    Naslov = "Vojkova cesta 19",
                    Posta = "1000",
                    Kraj = "Ljubljana",
                    Email = "info@gzl.si",
                    Telefon = "051 660 098",
                    SpletnaStran = "https://www.gzl.si",
                    MaticnaStevilka = "5916780000",
                    DavcnaStevilka = "91098769"
                },
                new GasilskaZveza
                {
                    Naziv = "Gasilska zveza Škofja Loka",
                    Naslov = "Kidričeva c. 51a",
                    Posta = "4220",
                    Kraj = "Škofja Loka",
                    Email = "info@gz-skofjaloka.si",
                    Telefon = "041 730 995",
                    SpletnaStran = "https://www.gz-skofjaloka.si",
                    MaticnaStevilka = "5159806000",
                    DavcnaStevilka = "26465019"
                }
            );

            await context.SaveChangesAsync();
        }
    }
}