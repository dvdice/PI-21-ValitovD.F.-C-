using System;
using System.Runtime.Serialization;

namespace WindowsFormsCars
{
    class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException() : base("Место занято")
        {  }
    }
}