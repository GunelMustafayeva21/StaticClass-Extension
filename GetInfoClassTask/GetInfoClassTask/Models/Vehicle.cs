using System;
using System.Collections.Generic;
using System.Text;

namespace LastDayMarch.Models
{
    public abstract class Vehicle
    {
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }

        public abstract double AverageSpeed();
        public abstract void ShowInfo();

        public Vehicle()
        {

        }

        public Vehicle(int DriveTime, int DrivePath)
        {
            this.DriveTime = DriveTime;
            this.DrivePath = DrivePath;
        }
        
    }
}