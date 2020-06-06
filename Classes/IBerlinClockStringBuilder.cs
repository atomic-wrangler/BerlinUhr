using System;

namespace BerlinClock.Classes
{
    public interface IBerlinClockStringBuilder
    {
        string Build(DateTime time);
    }
}