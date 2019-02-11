namespace PostageCalculator.Classes
{
    public class NextDay : Spu
    {
        public override double CalculateRate(int distance, double weight)
        {
            double poundConversion = weight / 16;

            return (poundConversion * 0.075) * distance;
        }
    }

}
