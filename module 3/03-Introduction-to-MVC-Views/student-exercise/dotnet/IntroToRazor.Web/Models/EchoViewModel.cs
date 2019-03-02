using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToRazor.Web.Models
{
    public class EchoViewModel
    {
        public int NumOfTimes { get; set; } = 10;
        public string Phrase { get; set; } = "Echo";
    }
}
