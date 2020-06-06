using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BerlinClock
{
    //TODO: Replace with relevant explicit cast operators to confine to interface segregation principle
    //TODO: Implement a conversion to and from BerlinClock.Models.BerlinClockModel
    //since it would provide a consistent and universal representation of the clock
    public class TimeConverter : ITimeConverter
    {
        private IBerlinClockStringBuilder _stringBuilder;

        public TimeConverter(IBerlinClockStringBuilder stringBuilder)
        {
            _stringBuilder = stringBuilder;
        }

        //TODO: clarify the expected input time format and provide custom parsing if necessary
        public string ConvertTime(string aTime)
        {
            aTime = Regex.Replace(aTime, @"24:(\d\d:\d\d)$", "00:$1");

            if (!DateTime.TryParse(aTime, out var time)) 
            {
                throw new ArgumentException("Provided time string is invalid");
            }

            return _stringBuilder.Build(time);
        }
    }
}
