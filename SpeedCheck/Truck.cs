using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedCheck
{
    public class Truck:Vehicle
    {
        private int _maxLoad;

        public int MaxLoad
        {
            get { return _maxLoad; }
            set { _maxLoad = value; }
        }

        public Truck(int maxLoad, string regNo)
        {
            _maxLoad = maxLoad;
            _regNo = regNo;
        }

    }
}
