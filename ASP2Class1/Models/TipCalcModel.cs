using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    using System.ComponentModel.DataAnnotations;
    public class TipCalcModel
    {
        [Required(ErrorMessage = "Please enter a meal cost.")]
        public decimal? MealCost { get; set; }

        public decimal? Tip15 { get; set; }
        public decimal? Tip20 { get; set; }
        public decimal? Tip25 { get; set; }

        // Methods for Calculating the Tip based on MealCost. //
        public decimal? CalculateTip15()
        {
            Tip15 = MealCost * 0.15m;
            return Tip15;
        }

        public decimal? CalculateTip20()
        {
            Tip20 = MealCost * 0.20m;
            return Tip20;
        }

        public decimal? CalculateTip25()
        {
            Tip25 = MealCost * 0.25m;
            return Tip25;
        }
    }
}
