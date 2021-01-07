using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedCheck
{
    public abstract class Vehicle
    {
        protected string _regNo;

        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }


    }
}
