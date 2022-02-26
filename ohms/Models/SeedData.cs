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
                        Ppmk = 250,
                        TCLetter = "U"

                    },
                    new ohmsClass
                    {
                        Name = "Brown",
                        Code = "BN",
                        RAL = 8003,
                        SigFig = "1",
                        Multiplier = 10 ^ 1,
                        Multiplier2 = 10,
                        Percent = "1",
                        Letter = "F",
                        Ppmk = 100,
                        TCLetter = "S"

                    },
                    new ohmsClass
                    {
                        Name = "Red",
                        Code = "RD",
                        RAL = 3000,
                        SigFig = "2",
                        Multiplier = 10 ^ 2,
                        Multiplier2 = 100,
                        Percent = "2",
                        Letter = "G",
                        Ppmk = 50,
                        TCLetter = "R"

                    },
                    new ohmsClass
                    {
                        Name = "Orange",
                        Code = "OG",
                        RAL = 2003,
                        SigFig = "3",
                        Multiplier = 10 ^ 3,
                        Multiplier2 = 1000,
                        Percent = "0.05",
                        Letter = "W",
                        Ppmk = 15,
                        TCLetter = "P"

                    },
                    new ohmsClass
                    {
                        Name = "Yellow",
                        Code = "YE",
                        RAL = 1021,
                        SigFig = "4",
                        Multiplier = 10 ^ 4,
                        Multiplier2 = 10000,
                        Percent = "0.02^[8][nb 1][9]",
                        Letter = "P",
                        Ppmk = 25,
                        TCLetter = "Q"

                    },
                    new ohmsClass
                    {
                        Name = "Green",
                        Code = "GN",
                        RAL = 6018,
                        SigFig = "5",
                        Multiplier = 10 ^ 5,
                        Multiplier2 = 100000,
                        Percent = "0.5",
                        Letter = "D",
                        Ppmk = 20,
                        TCLetter = "Z^[nb 2]"

                    },
                    new ohmsClass
                    {
                        Name = "Blue",
                        Code = "BU",
                        RAL = 5015,
                        SigFig = "6",
                        Multiplier = 10 ^ 6,
                        Multiplier2 = 1000000,
                        Percent = "0.25",
                        Letter = "C",
                        Ppmk = 10,
                        TCLetter = "Z^[nb 2]"

                    },
                    new ohmsClass
                    {
                        Name = "Violet",
                        Code = "VT",
                        RAL = 4005,
                        SigFig = "7",
                        Multiplier = 10 ^ 7,
                        Multiplier2 = 10000000,
                        Percent = "0.01",
                        Letter = "B",
                        Ppmk = 10,
                        TCLetter = "M"

                    },
                    new ohmsClass
                    {
                        Name = "Grey",
                        Code = "GY",
                        RAL = 7000,
                        SigFig = "8",
                        Multiplier = 10 ^ 8,
                        Multiplier2 = 100000000,
                        Percent = "0.01^[8][nb 3][nb 1][9]",
                        Letter = "L(A)",
                        Ppmk = 1,
                        TCLetter = "K"

                    },
                    new ohmsClass
                    {
                        Name = "White",
                        Code = "WH",
                        RAL = 1013,
                        SigFig = "9",
                        Multiplier = 10 ^ 9,
                        Multiplier2 = 1000000000,
                        Percent = "-",
                        Letter = "-",
                        Ppmk = 0,
                        TCLetter = "-"

                    }
); ;
                context.SaveChanges();
            }
        }
    }
}