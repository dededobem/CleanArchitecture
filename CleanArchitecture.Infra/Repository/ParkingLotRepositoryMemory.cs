using CleanArchitecture.Adapter;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Repository
{
    public class ParkingLotRepositoryMemory : IParkingLotRepository
    {

        public List<ParkedCar> parkedCars { get; set; } = new List<ParkedCar>();
        public List<ParkingLot> parkingLots { get; set; } = new List<ParkingLot>();

        public async Task<ParkingLot> GetParkingLot(string code)
        {
            parkingLots.Add(new ParkingLot("shopping", 5, 8, 22, 0));
            parkingLots.Add(new ParkingLot("drugstore", 5, 7, 19, 0));

            var parkingLotData = parkingLots.Find(x => x.Code == code);
            var occupiedSpace = parkedCars.Count;
            var parkingLot = ParkingLotAdapter
                .Create(parkingLotData.Code, parkingLotData.Capacity, 
                    parkingLotData.OpenHour, parkingLotData.CloseHour, occupiedSpace);            

            return parkingLot;
        }

        public async Task SaveParkedCar(string code, string plate, DateTime date)
        {
            parkedCars.Add(new ParkedCar(code, plate, date));
        }
    }
}
