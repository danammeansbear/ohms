#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ohms.Data;
using ohms.Models;


namespace ohms.Controllers
{

    public class ohmsClassesController : Controller
    {
        private readonly ohmsContext _context;

        public async Task<IActionResult> YourAction(ohmsClass ohms )
        {
            //C# code here
            //algorithm
            // bandAColor + bandBColor + bandCColor(number of zeros) = q = q~=k(ohms)
            // yellow purple black orange = 470 k(ohms)
            //Name	Code	RAL	Percent [%]	Letter	[ppm/K]	Letter
            //Pink	PK	3015	–	×10−3[8]	×0.001	–	–
            ModelState.Clear();
            string bandAColor, bandBColor, bandCColor, bandDColor;
           
            List<ohmsClass> listOfColors = new List<ohmsClass>() {

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

                    }};
            //listOfColors[0].Name;
            
            for (int i = 0; i < listOfColors.Count; i++)
            {
                int selectedFunction = Convert.ToInt32(Request.Form["calkey"]);
                //Random ran = new Random();
                //Console.WriteLine("Random Ohm " + listOfColors[ran.Next(5)].Name + listOfColors[ran.Next(5)].Name + listOfColors[ran.Next(5)].Name + listOfColors[ran.Next(5)].Name);
                var None = listOfColors.SingleOrDefault(c => c.Name == "None");
                var NoneValue = listOfColors.SingleOrDefault(c => c.SigFig == "-");
                var Pink = listOfColors.SingleOrDefault(c => c.Name == "Pink");
                var PinkValue = listOfColors.SingleOrDefault(c => c.SigFig == "-");
                var Silver = listOfColors.SingleOrDefault(c => c.Name == "Silver");
                var SilverValue = listOfColors.SingleOrDefault(c => c.SigFig == "-");
                var Gold = listOfColors.SingleOrDefault(c => c.Name == "Gold");
                var GoldValue = listOfColors.SingleOrDefault(c => c.SigFig == "-");
                var Black = listOfColors.SingleOrDefault(c => c.Name == "Black");
                var Brown = listOfColors.SingleOrDefault(c => c.Name == "Brown");
                var Red = listOfColors.SingleOrDefault(c => c.Name == "Red");
                var Orange = listOfColors.SingleOrDefault(c => c.Name == "Orange");
                var Yellow = listOfColors.SingleOrDefault(c => c.Name == "Yellow");
                var Green = listOfColors.SingleOrDefault(c => c.Name == "Green");
                var Blue = listOfColors.SingleOrDefault(c => c.Name == "Blue");
                var Violet = listOfColors.SingleOrDefault(c => c.Name == "Violet");
                var Grey = listOfColors.SingleOrDefault(c => c.Name == "Grey");
                var White = listOfColors.SingleOrDefault(c => c.Name == "White");

            }
           
            
            return View();
        }
        
       
        public ActionResult Result(ohmsClass ohms)
        {

            return View(ohms);
        }
        public ohmsClassesController(ohmsContext context)
        {
            _context = context;
        }

        // GET: ohmsClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.ohmsClass.ToListAsync());
        }

        // GET: ohmsClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ohmsClass = await _context.ohmsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ohmsClass == null)
            {
                return NotFound();
            }

            return View(ohmsClass);
        }

        // GET: ohmsClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ohmsClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,RAL,SigFig,Multiplier,Multiplier2,Percent,Letter,Ppmk,TCLetter")] ohmsClass ohmsClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ohmsClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ohmsClass);
        }
        /*
        // POST: ohmsClasses/CalculateNewOhm
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YourAction([Bind("Id,Name,Code,RAL,SigFig,Multiplier,Multiplier2,Percent,Letter,Ppmk,TCLetter")] ohmsClass ohmsClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ohmsClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ohmsClass);
        }
        */
        // GET: ohmsClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ohmsClass = await _context.ohmsClass.FindAsync(id);
            if (ohmsClass == null)
            {
                return NotFound();
            }
            return View(ohmsClass);
        }

        // POST: ohmsClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code,RAL,SigFig,Multiplier,Multiplier2,Percent,Letter,Ppmk,TCLetter")] ohmsClass ohmsClass)
        {
            if (id != ohmsClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ohmsClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ohmsClassExists(ohmsClass.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ohmsClass);
        }

        // GET: ohmsClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ohmsClass = await _context.ohmsClass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ohmsClass == null)
            {
                return NotFound();
            }

            return View(ohmsClass);
        }

        // POST: ohmsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ohmsClass = await _context.ohmsClass.FindAsync(id);
            _context.ohmsClass.Remove(ohmsClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ohmsClassExists(int id)
        {
            return _context.ohmsClass.Any(e => e.Id == id);
        }
    }
}
