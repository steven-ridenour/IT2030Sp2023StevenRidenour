using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for cost of meal.")]
        // Changed ErrorMessage to better represent the possible range
        [Range(0.0, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero and less than $10000000.00")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                // changed divide to multiply
                var tip = MealCost.Value * percent;
                //added a semicolon
                return tip;
            }
            else
            {
                return 0;
            }
        }
    }
}