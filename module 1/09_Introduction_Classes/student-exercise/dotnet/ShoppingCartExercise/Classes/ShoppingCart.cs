using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {

        public int TotalNumberOfItems { get; private set; }
        public decimal TotalAmountOwed { get; private set; }

        public decimal GetAveragePricePerItem()
        {
            decimal result = 0;

            if(TotalNumberOfItems == 0)
            {
                result = 0;
            }
            else
            {
                result = TotalAmountOwed / TotalNumberOfItems;
            }

            return result;
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems = numberOfItems;

            TotalAmountOwed += pricePerItem * numberOfItems;
        }

        public void Empty()
        {
            TotalAmountOwed = 0;
            TotalNumberOfItems = 0;
        }
    }
}
