using System;

namespace CISBicycle
{
    /// <summary>
    /// Basic bicycle class tracking a short biking segment keeping track of the bike's cadence, gear, and speed.
    /// </summary>
    public class Bicycle
    {
        // The Bicycle class has three fields
        protected int cadence;
        protected int gear;
        protected int speed;

        // The Bicycle class has one constructor
        public Bicycle(int startCadence, int startSpeed, int startGear)
        {
            gear = startGear;
            cadence = startCadence;
            speed = startSpeed;
        }

        // The Bicycle class has four methods
        public void SetCadence(int newValue)
        {
            cadence = newValue;
        }

        public void SetGear(int newValue)
        {
            gear = newValue;
        }

        public int GetCadence()
        {
            return cadence;
        }

        public int GetGear()
        {
            return gear;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void ApplyBrake(int decrement)
        {
            speed -= decrement;
        }

        public void SpeedUp(int increment)
        {
            speed += increment;
        }

        public override string ToString()
        {
            return $"My Bike: {speed}, {GetCadence()}, {gear}";
        }
    }
}
