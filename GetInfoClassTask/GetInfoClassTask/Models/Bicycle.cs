using GetInfoClassTask;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastDayMarch.Models
{
    class Bicycle : Vehicle,  IWheel, ITransmission
    {
        public string PedalKind { get; set; }
       
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }
        public Bicycle(int DriveTime, int DrivePath, string PedalKind,  double WheelThickness, string TransmissionKind) : base(DriveTime, DrivePath)
        {
            this.PedalKind= PedalKind;
            
            this.WheelThickness = WheelThickness;
            this.TransmissionKind = TransmissionKind;

        }

        
        public override double AverageSpeed()
        {
            return DrivePath/DriveTime;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("DriveTime--> " + DriveTime + " DrivePath--> " + DrivePath + " PedalKind-->  " + PedalKind +  " WheelThickness--> " + WheelThickness+ " TransmissionKind--> " + TransmissionKind);



        }

        
    }
}