using System.ComponentModel.DataAnnotations;

namespace FutureValCal.Models
{
    public class FutureValModel
    {
        [Required(ErrorMessage = "Enter Monthly investment")]
        [Range(1, 20, ErrorMessage = "Range must be between 1 and 20")]
        public double? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Enter Interest rate investment")]
        [Range(1, 20, ErrorMessage = "Range must be between 0.1 and 10.0")]
        public double? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Enter YEars")]
        [Range(1, 20, ErrorMessage = "Range must be between 1 and 20")]
        public int? Years { get; set; }

        public double Calculate()
        {
            int months = Years.Value * 12;
            double monthlyInterestRate = YearlyInterestRate.Value / 12 / 100;
            double futureValue = 0;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment.Value) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}
