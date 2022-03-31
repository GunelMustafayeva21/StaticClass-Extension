using GetInfoClassTask;

using System;
using System.Collections.Generic;
using System.Text;

namespace LastDayMarch.Models
{
    class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        public int DoorCount { get; set; }
        public string WinCode { get; set; }
        public int HorsePower { set; get; }
        public double TankSize { set; get; }

        public double CurrentFuel { get; set; }
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }
        public Car(int DriveTime, int DrivePath, int DoorCount, string WinCode, int HorsePower, double TankSize, double CurrentFuel, double WheelThickness, string TransmissionKind) : base(DriveTime, DrivePath)
        {
            this.DoorCount = DoorCount;
            this.WinCode = WinCode;
            this.HorsePower = HorsePower;
            this.TankSize = TankSize;
            this.CurrentFuel = CurrentFuel;
            this.WheelThickness = WheelThickness;
            this.TransmissionKind = TransmissionKind;

        }
        public double LeftFuelAmount()
        {
            return TankSize - CurrentFuel;
        }
        public override double AverageSpeed()
        {
            return  DrivePath/DriveTime;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("DriveTime--> " + DriveTime + "  DrivePath--> " + DrivePath + "  DoorCount-->  " + DoorCount + "  WinCode-->  "+ WinCode+  "  HorsePower-->  "+ HorsePower+  "  TankSize-->  " + TankSize+ "  CurrentFuel-->  "+ CurrentFuel+  "  WheelThickness-->  " + WheelThickness+ "  TransmissionKind-->  "+ TransmissionKind );



        }

    }
}
