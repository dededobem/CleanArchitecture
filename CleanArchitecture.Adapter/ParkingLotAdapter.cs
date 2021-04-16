using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Adapter
{
    public class ParkingLotAdapter
    {
        public static ParkingLot Create(string code, int capacity, int openHour, int closeHour, int occupiedSpaces)
        {
            return new ParkingLot(code, capacity, openHour, closeHour, occupiedSpaces);
        }
    }
}
