namespace PostageCalculator.Classes
{
    public class ThirdClass : PostalService
    {
        public override double CalculateRate(int distance, double weight)
        {
            double ratePerMile = 0.017;

            if (weight >= 0 && weight <= 2)
            {
                ratePerMile = 0.002;

            }
            else if (weight >= 3 && weight <= 8)
            {
                ratePerMile = 0.0022;

            }
            else if (weight >= 9 && weight <= 15)
            {
                ratePerMile = 0.0024;

            }
            else if (weight >= 16 && weight <= 48)
            {
                ratePerMile = 0.015;

            }
            else if (weight >= 64 && weight <= 128)
            {
                ratePerMile = 0.016;
            }

            return distance * ratePerMile;
        }
    }
}
