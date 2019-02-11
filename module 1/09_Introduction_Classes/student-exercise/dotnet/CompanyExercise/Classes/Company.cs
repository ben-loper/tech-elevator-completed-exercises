using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        //Properties for a Company object
        public string Name { get; private set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }


        //Constructor used to create objects using the Company class
        public Company(string startingName)
        {
            Name = startingName;
        }

        public string GetCompanySize()
        {
            string companySize = "small";

            if(NumberOfEmployees >= 50 && NumberOfEmployees <= 250)
            {
                companySize = "medium";
            } else if(NumberOfEmployees > 250)
            {
                companySize = "large";
            }
            return companySize;
        }

        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }
    }
}
