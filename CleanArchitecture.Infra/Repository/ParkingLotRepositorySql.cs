using CleanArchitecture.Adapter;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infra.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Repository
{
    public class ParkingLotRepositorySql : IParkingLotRepository
    {
        private readonly CleanArchitectureContext _context;
        public ParkingLotRepositorySql(CleanArchitectureContext context)
        {
            _context = context;
        }
        public async Task<ParkingLot> GetParkingLot(string code)
        {
            var parkingLotData = _context.ParkingLots.FirstOrDefault(x => x.Code == code);
            var occupiedSpace = _context.ParkedCars.Count();
            var parkingLot = ParkingLotAdapter
                .Create(parkingLotData.Code, parkingLotData.Capacity, 
                    parkingLotData.OpenHour, parkingLotData.CloseHour, occupiedSpace);            

            return parkingLot;
        }

        public async Task SaveParkedCar(string code, string plate, DateTime date)
        {
            _context.ParkedCars.Add(new ParkedCar(code, plate, date));
            await _context.SaveChangesAsync();
        }
    }
}
