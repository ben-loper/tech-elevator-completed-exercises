using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        //Properties

        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats { get; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        public int TotalCoachSeats { get; }


        //Constructor
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool result = false;

            if(forFirstClass)
            {
                if(AvailableFirstClassSeats >= BookedFirstClassSeats + totalNumberOfSeats)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    result = true;
                }   
            }
            else
            {
                if(AvailableCoachSeats >= BookedCoachSeats + totalNumberOfSeats)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    result = true;
                }                
            }
            return result;
        }
    }
}
