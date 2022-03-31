using LastDayMarch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInfoClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car (2, 20, 4, "abcd", 400, 68.5, 30.00, 70, "Land");
            Bicycle b = new Bicycle(3, 30, "Chainy", 20.00, "land");
            Plane p = new Plane(2, 200, 3, 1000, 100.00, 80.00, "air");
            //c.ShowInfo();
            //b.ShowInfo();
            p.ShowInfo();
        }
    } 
    interface IEngine
    {
         int HorsePower { set; get; }
         double TankSize { set; get; }

        double CurrentFuel { get; set; }

        double LeftFuelAmount();


    }

     public interface IWheel
    {
         double WheelThickness { get; set; }
    }

     public interface ITransmission
    {
          string TransmissionKind { get; set; }
    }



}
