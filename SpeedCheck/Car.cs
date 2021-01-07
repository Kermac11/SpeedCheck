using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedCheck
{
    public class Car: Vehicle
    {
        private int _noOfPersons;

        public int NoOfPersons
        {
            get { return _noOfPersons; }
            set { _noOfPersons = value; }
        }

        public Car(int noOfPersons, string regNo)
        {
            _noOfPersons = noOfPersons;
            _regNo = regNo;
        }
    }
}
