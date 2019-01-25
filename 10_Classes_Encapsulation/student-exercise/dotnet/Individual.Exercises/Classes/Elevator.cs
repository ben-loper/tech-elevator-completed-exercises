using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; }
        public bool DoorIsOpen { get; private set; }

        private const int _lowestFloor = 1;

        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
        }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor <= NumberOfLevels && CurrentLevel < desiredFloor)
            {
                CurrentLevel = desiredFloor;
            }
        }

        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor >= _lowestFloor && CurrentLevel > desiredFloor)
            {
                CurrentLevel = desiredFloor;
            }
        }
    }

}
