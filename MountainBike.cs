using System;

namespace CISBicycle
{
    /// <summary>
    /// This class inherits from the Bicycle class adding the seat height attribute.
    /// </summary>
    public class MountainBike : Bicycle
    {
        // The MountainBike subclass adds one field
        public int SeatHeight { get; private set; }

        // The MountainBike subclass has one constructor
        public MountainBike(int startHeight, int startCadence, int startSpeed, int startGear)
            : base(startCadence, startSpeed, startGear)
        {
            SeatHeight = startHeight;
        }

        // The MountainBike subclass adds one method
        public void SetHeight(int newValue)
        {
            SeatHeight = newValue;
        }

        public int GetHeight()
        {
            return SeatHeight;
        }

        public override string ToString()
        {
            return $"My MountainBike: {GetSpeed()}, {GetCadence()}, {GetGear()}, {SeatHeight}";
        }
    }
}
