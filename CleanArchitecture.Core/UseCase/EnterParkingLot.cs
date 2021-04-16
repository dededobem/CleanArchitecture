using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.UseCase
{
    public class EnterParkingLot
    {
        private readonly IParkingLotRepository _parkingLotRepository;
        private readonly IParkedCarRepository _parkedCarRepository;

        public EnterParkingLot(IParkingLotRepository parkingLotRepository, 
            IParkedCarRepository parkedCarRepository)
        {
            _parkingLotRepository = parkingLotRepository;
            _parkedCarRepository = parkedCarRepository;
        }

        public async Task<ParkingLot> Execute(string code, string plate, DateTime date)
        {
            var parkingLot = await _parkingLotRepository.GetParkingLot(code);
            var parkedCar = new ParkedCar(code, plate, date);

            if (!parkingLot.IsOpen(parkedCar.Date)) throw new Exception("The parking lot is closed");
            if (parkingLot.IsFull()) throw new Exception("The parking lot is full");

            await _parkedCarRepository.SaveParkedCar(parkedCar.Code, parkedCar.Plate, parkedCar.Date);

            return parkingLot;
        }
    }
}
