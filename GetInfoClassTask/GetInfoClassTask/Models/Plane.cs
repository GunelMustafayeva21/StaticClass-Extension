using GetInfoClassTask;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastDayMarch.Models
{
    class Plane : Vehicle, IEngine, ITransmission
    {
        public int WingLength { get; set; }
        public int HorsePower { set; get; }
        public double TankSize { set; get; }

        public double CurrentFuel { get; set; }
        public string TransmissionKind { get; set; }
        public Plane(int DriveTime, int DrivePath,int WingLength, int HorsePower, double TankSize, double CurrentFuel, string TransmissionKind):base( DriveTime, DrivePath)
        {
                this.WingLength = WingLength;
            this.HorsePower = HorsePower;
            this.TankSize = TankSize;
                this.CurrentFuel = CurrentFuel;
            this.TransmissionKind = TransmissionKind;

        }
        public double LeftFuelAmount()
        {
            return TankSize - CurrentFuel;
        }

        public override double AverageSpeed()
        {
            return DriveTime * DrivePath;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("DriveTime--> "+ DriveTime+ "  DrivePath--> "+ DrivePath+"  WingLength--> " + WingLength + "  HorsePower--> " + HorsePower + "  TankSize--> " + TankSize + "  CurrentFuel--> " + CurrentFuel + "  TransmissionKind--> " + TransmissionKind);
            


        }
    }
}
