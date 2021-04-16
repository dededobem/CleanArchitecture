using CleanArchitecture.Adapter;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Repository
{
    public class ParkingLotRepositoryMemory : IParkingLotRepository
    {

        public List<ParkingLot> ParkingLots;
        public async Task<ParkingLot> GetParkingLot(string code)
        {
            ParkingLots.Add(new ParkingLot("shopping", 5, 8, 22, 0));
            ParkingLots.Add(new ParkingLot("drugstore", 5, 7, 19, 0));

            var parkingLotData = ParkingLots.Find(x => x.Code == code);
            var parkingLot = ParkingLotAdapter
                .Create(parkingLotData.Code, parkingLotData.Capacity, 
                    parkingLotData.OpenHour, parkingLotData.CloseHour, parkingLotData.OccupiedSpaces);            

            return parkingLot;
        }
    }
}
