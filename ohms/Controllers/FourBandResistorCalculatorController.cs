using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ohms.Core.Calculators.OhmValueCalculator;
using ohms.core.Models.ColorCodeBand;


namespace ElectronicColorCodeCalculator.Mvc.Controllers
{
    public class FourBandResistorCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromServices] IFourColorCodeBandsViewModel viewModel) =>
            View(viewModel);

        [HttpPost]
        public IActionResult Calculate(string bandAColor, string bandBColor, string bandCColor, string bandDColor
            , [FromServices] IOhmValueCalculator fourBandResistorCalculator
            , [FromServices] IFourColorCodeBandsViewModel fourColorCodeBandsViewModel) =>
                Json(fourBandResistorCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor)
                    .ToFormattedOhms(bandDColor, fourColorCodeBandsViewModel));
    }
}