using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedCheck
{
    public class SpeedMeasurement
    {
        private static int _staticId = 0;

        private DateTime _timeStamp;

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private int _id;
            
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public SpeedMeasurement(int speed)
        {
            _timeStamp = DateTime.Now;
            _speed = speed;
            _id = _staticId++;
        }

        public override string ToString()
        {
            return $"Timestamp: {_timeStamp} || Speedlimit: {_speed} || ID: {_id}";
        }
    }
}
