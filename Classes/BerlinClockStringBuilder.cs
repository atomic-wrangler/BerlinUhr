using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class BerlinClockStringBuilder : IBerlinClockStringBuilder
    {
        private const string OFF = "O";
        private const string RED = "R";
        private const string YELLOW = "Y";

        public string Build(DateTime time)
        {
            var sb = new StringBuilder();

            sb.AppendLine(GetTopLampState(time));
            sb.AppendLine(BuildHours(time));
            sb.Append(BuildMinutes(time));

            return sb.ToString();
        }

        private string GetTopLampState(DateTime time) 
        {
            var topLampState = (time.Second % 2 == 0) ? YELLOW : OFF;
            return topLampState;
        }

        private string BuildHours(DateTime time)
        {
            var fiveHourIntervals = Math.DivRem(time.Hour, 5, out var oneHourIntervals);
            var sb = new StringBuilder();

            for (var i = 0; i < 4; i++)
            {
                sb.Append((i < fiveHourIntervals) ? RED : OFF);
            }

            sb.AppendLine();

            for (var i = 0; i < 4; i++)
            {
                sb.Append((i < oneHourIntervals) ? RED : OFF);
            }

            return sb.ToString();
        }

        private static string BuildMinutes(DateTime time)
        {
            var fiveMinuteIntervals = Math.DivRem(time.Minute, 5, out var oneMinuteIntervals);
            var sb = new StringBuilder();

            for (var i = 1; i <= fiveMinuteIntervals; i++)
            {
                sb.Append((i % 3 == 0) ? RED : YELLOW);
            }

            for (var i = fiveMinuteIntervals; i < 11; i++)
            {
                sb.Append(OFF);
            }

            sb.AppendLine();

            for (var i = 0; i < 4; i++)
            {
                sb.Append((i < oneMinuteIntervals) ? YELLOW : OFF);
            }

            return sb.ToString();
        }
    }
}
