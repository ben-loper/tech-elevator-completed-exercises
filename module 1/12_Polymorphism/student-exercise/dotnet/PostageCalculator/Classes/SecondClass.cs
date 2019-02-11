namespace PostageCalculator.Classes
{
    public class SecondClass : PostalService
    {
        public override double CalculateRate(int distance, double weight)
        {
            double ratePerMile = 0.05;

            if (weight >= 0 && weight <= 2)
            {
                ratePerMile = 0.0035;

            }
            else if (weight >= 3 && weight <= 8)
            {
                ratePerMile = 0.0040;

            }
            else if (weight >= 9 && weight <= 15)
            {
                ratePerMile = 0.0047;

            }
            else if (weight >= 16 && weight <= 48)
            {
                ratePerMile = 0.0195;

            }
            else if (weight >= 64 && weight <= 128)
            {
                ratePerMile = 0.0450;
            }

            return distance * ratePerMile;
        }
    }
}
