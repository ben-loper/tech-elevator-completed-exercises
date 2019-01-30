namespace PostageCalculator.Classes
{
    public class TwoDayBusiness : Spu
    {
        public override double CalculateRate(int distance, double weight)
        {
            double poundEquality = weight / 16;

            return (poundEquality * 0.050) * distance;
        }
    }
}
