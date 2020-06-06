using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Models
{
    public class BerlinClockModel
    {
        #region Private fields

        private bool[] _fiveHourLampsRow = new bool[4];

        private bool[] _oneHourLampsRow = new bool[4];

        private bool[] _fiveMinutesLampsRow = new bool[11];

        private bool[] _oneMinuteLampsRow = new bool[4];

        #endregion

        public bool TwoSecondsLamp { get; set; }

        public bool[] FiveHourLampsRow 
        {
            get { return _fiveHourLampsRow; }
        }

        public bool[] OneHourLampsRow
        {
            get { return _oneHourLampsRow; }
        }

        public bool[] FiveMinutesLampsRow
        {
            get { return _fiveMinutesLampsRow; }
        }

        public bool[] OneMinuteLampsRow
        {
            get { return _oneMinuteLampsRow; }
        }
    }
}
