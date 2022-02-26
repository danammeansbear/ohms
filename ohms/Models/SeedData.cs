using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MvcMovie.Data;
using ohms.Data;
using System;
using System.Linq;

namespace ohms.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ohmsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ohmsContext>>()))
            {
                // Look for any movies.
                if (context.ohmsClass.Any())
                {
                    return;   // DB has been seeded
                }

                context.ohmsClass.AddRange(
                    new ohmsClass
                    {
                        Name = "None",
                        Code = "0",
                        RAL = 0,
                        SigFig = "-",
                        Multiplier = 10^-3,
                        Multiplier2 = 0.001,
                        Percent = "20",
                        Letter = "M",
                        Ppmk = 0,
                        TCLetter = "0"

                    },
                    new ohmsClass
                    {
                        Name = "Pink",
                        Code = "PK",
                        RAL = 3015,
                        SigFig = "-",
                        Multiplier = 10 ^ -2,
                        Multiplier2 = 0.01,
                        Percent = "0",
                        Letter = "M",
                        Ppmk = 0,
                        TCLetter = "0"

                    },
                    new ohmsClass
                    {
                        Name = "Silver",
                        Code = "SR",
                        RAL = 0,
                        SigFig = "-",
                        Multiplier = 10 ^ -1,
                        Multiplier2 = 0.1,
                        Percent = "10",
                        Letter = "K",
                        Ppmk = 0,
                        TCLetter = "0"

                    }, 
                    new ohmsClass
                    {
                        Name = "Gold",
                        Code = "GD",
                        RAL = 0,
                        SigFig = "-",
                        Multiplier = 10 ^ -1,
                        Multiplier2 = 0.1,
                        Percent = "5",
                        Letter = "J",
                        Ppmk = 0,
                        TCLetter = "0"

                    },
                    new ohmsClass
                    {
                        Name = "Black",
                        Code = "BK",
                        RAL = 9005,
                        SigFig ="0",
                        Multiplier = 10 ^ -0,
                        Multiplier2 = 1,
                        Percent = "20",
                        Letter = "M",
                        Ppmk = 0,
                        TCLetter = "0"

                    }
); ;
                context.SaveChanges();
            }
        }
    }
}