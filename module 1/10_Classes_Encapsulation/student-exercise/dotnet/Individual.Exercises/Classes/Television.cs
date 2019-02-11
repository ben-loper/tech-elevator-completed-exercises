using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        private const int _maximumChannel = 18;
        private const int _minimumChannel = 3;
        private const int _maximumVolume = 10;
        private const int _minimumVolume = 0;


        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel >= _minimumChannel && newChannel <= _maximumChannel)
            {
                CurrentChannel = newChannel;
            }
            
        }
        public void ChannelUp()
        {
            if (IsOn)
            {
                if (CurrentChannel < _maximumChannel)
                {
                    CurrentChannel++;
                }
                else
                {
                    CurrentChannel = _minimumChannel;
                }
            }
        }
        public void ChannelDown()
        {
            if (IsOn)
            {
                if (CurrentChannel > _minimumChannel)
                {
                    CurrentChannel--;
                }
                else
                {
                    CurrentChannel = _maximumChannel;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn)
            {
                if(CurrentVolume < _maximumVolume)
                {
                    CurrentVolume++;
                }
            }
        }
        public void LowerVolume()
        {
            if (IsOn)
            {
                if(CurrentVolume > _minimumVolume)
                {
                    CurrentVolume--;
                }
            }
        }

    }
}
