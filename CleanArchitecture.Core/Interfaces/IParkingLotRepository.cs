using CleanArchitecture.Core.Entities;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IParkingLotRepository
    {
        Task<ParkingLot> GetParkingLot(string code);
        Task SaveParkedCar(string code, string plate, DateTime date);
    }
}
