namespace PostageCalculator.Classes
{
    public class PostalService : IDeliveryDriver
    {
        public virtual double CalculateRate(int distance, double weight)
        {
            return 0.0;
        }
    }
}
