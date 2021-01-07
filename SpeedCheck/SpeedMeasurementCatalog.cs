using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SpeedCheck
{
    public class SpeedMeasurementCatalog
    {
        public List<SpeedMeasurement> _speedList;
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _zone;

        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        private int _speedLimit;

        public int SpeedLimit
        {
            get { return _speedLimit; }
            set { _speedLimit = value; }
        }

        public SpeedMeasurementCatalog(string address, string zone, int speedLimit)
        {
            _speedList = new List<SpeedMeasurement>();
            _address = address;
            _zone = zone;
            _speedLimit = speedLimit;
        }

        public void AddSpeedMeasurement(int speed)
        {
            if (speed > 300 || speed<0)
            {
                throw new ArgumentException($"Measurement is not valid. recorded is {speed}");
            }
            SpeedMeasurement s = new SpeedMeasurement(speed);
            _speedList.Add(s);
        }

        public double AverageSpeed()
        {
            double value = 0;
            foreach (SpeedMeasurement speedMeasurement in _speedList)
            {
                value += speedMeasurement.Speed;
            }

            return value / _speedList.Count;
        }

        public int NoOfOverSpeedLiimit()
        {
            int counter = 0;
            int i = 0;
            while (i < _speedList.Count)
            {
                if (_speedList[i].Speed > SpeedLimit)
                {
                    counter++;
                }

                i++;
            }

            return counter;
        }

        public int NoOfCutinLicences()
        {
            int counter = 0;
            int i = 0;
            while (i < _speedList.Count)
            {
                if (_speedList[i].Speed > SpeedLimit * 1.3)
                {
                    counter++;
                }

                i++;
            }

            return counter;
        }

        public int NoOfConditionalRevocations()
        {
            int counter = 0;
            int i = 0;
            while (i < _speedList.Count)
            {
                if (SpeedLimit == 130 && _speedList[i].Speed > SpeedLimit * 1.3)
                {
                    counter++;
                } else if (_speedList[i].Speed > SpeedLimit * 1.6)
                {
                    counter++;
                }

                i++;
            }

            return counter;
        }

        public int NoOfunconditionalRevocations()
        {
            int counter = 0;
            int i = 0;
            while (i < _speedList.Count)
            {
                if (_speedList[i].Speed > SpeedLimit * 2 && _speedList[i].Speed >= 100)
                {
                    counter++;
                }

                i++;
            }

            return counter;
        }

        public override string ToString()
        {
            string s = $"Address: {_address} | Zone {_zone} | Speed Limit {_speedLimit}";
            foreach (SpeedMeasurement sm in _speedList)
            {
                s +="\n" + sm.ToString();
            }

            return s;
        }
    }
}
