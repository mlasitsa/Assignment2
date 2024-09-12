using System;

namespace CISBicycle
{
    // This is the main routine that tests out the Bicycle and MountainBike objects
    public class Program
    {
        public static void Main(string[] args)
        {
            Bicycle myBike = new Bicycle(1, 2, 3);
            MountainBike myMtnBike = new MountainBike(33, 1, 2, 3);

            Console.WriteLine("My Bike speed: " + myBike.GetSpeed());
            Console.WriteLine("My Mountain Bike speed: " + myMtnBike.GetSpeed());

            myBike.SpeedUp(5);
            myMtnBike.SpeedUp(3);

            Console.WriteLine("My Bike speed: " + myBike.GetSpeed());
            Console.WriteLine("My Mountain Bike speed: " + myMtnBike.GetSpeed());

            myBike.SetCadence(7);
            Console.WriteLine("My Bike cadence: " + myBike.GetCadence());

            myMtnBike.SetCadence(5);
            Console.WriteLine("My Mountain Bike cadence: " + myMtnBike.GetCadence());

            // This code fails, SetHeight & GetHeight are in MountainBike
            // myBike.SetHeight(33);
            // Console.WriteLine("My Bike height: " + myBike.GetHeight());

            myMtnBike.SetHeight(35);
            Console.WriteLine("My Mountain Bike height: " + myMtnBike.GetHeight());

            // Testing ToString()
            Console.WriteLine(myBike.ToString());
            Console.WriteLine(myMtnBike.ToString());
        }
    }
}