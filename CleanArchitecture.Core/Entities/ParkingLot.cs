using System;

namespace CleanArchitecture.Core.Entities
{
    public class ParkingLot
    {
        public ParkingLot(string code, int capacity, int openHour, int closeHour, int occupiedSpaces)
        {
            Code = code;
            Capacity = capacity;
            OpenHour = openHour;
            CloseHour = closeHour;
            OccupiedSpaces = occupiedSpaces;
        }

        public string Code { get; private set; }
        public int Capacity { get; private set; }
        public int OpenHour { get; private set; }
        public int CloseHour { get; private set; }
        public int OccupiedSpaces { get; set; }

        public bool IsOpen(DateTime date) => date.Hour >= OpenHour && date.Hour <= CloseHour;

        public bool IsFull() => OccupiedSpaces == Capacity;

    }
}
