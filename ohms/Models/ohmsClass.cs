using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ohms.Models
{
    public class ohmsClass
    {
        // Class contains an Id field, which is required
        // by the database for the primary key.
        public int Id { get; set; }

        // Ring Color
        public string Name { get; set; }
        public string Code { get; set; }
        public int RAL { get; set; }
        
        //Signigicant Figures
        public string SigFig { get; set; }
        
        //Multiplier
        public long Multiplier { get; set; }
        public double Multiplier2 { get; set; }
        
        //Tolerance
        public string Percent { get; set; }
        public string Letter { get; set; }
        
        //Temperature coefficient
        public long Ppmk { get; set; }
        public string TCLetter { get; set; }


        /*
        The electronic color code(http://en.wikipedia.org/wiki/Electronic_color_code) is 
        used to indicate the values or ratings of electronic components, very commonly 
        for resistors. Write a class that implements the following interface. Feel free
        to include any supporting types as necessary.
        
        */
        public interface IOhmValueCalculator
        {
            /// <summary>
            /// Calculates the Ohm value of a resistor based on the band colors.
            /// </summary>
            /// <param name="bandAColor">The color of the first figure of component value band.</param>
            /// <param name="bandBColor">The color of the second significant figure band.</param>
            /// <param name="bandCColor">The color of the decimal multiplier band.</param>
            /// <param name="bandDColor">The color of the tolerance value band.</param>
            int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
        }
       
    }
}
