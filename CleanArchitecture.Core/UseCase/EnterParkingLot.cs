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

        public EnterParkingLot(IParkingLotRepository parkingLotRepository)
        {
            _parkingLotRepository = parkingLotRepository;
        }

        public async Task<ParkingLot> Execute(string code, string plate, DateTime date)
        {
            var parkingLot = await _parkingLotRepository.GetParkingLot(code);
            var parkedCar = new ParkedCar(code, plate, date);

            if (!parkingLot.IsOpen(parkedCar.Date)) throw new Exception("The parking lot is closed");
            if (parkingLot.IsFull()) throw new Exception("The parking lot is full");

            await _parkingLotRepository.SaveParkedCar(parkedCar.Code, parkedCar.Plate, parkedCar.Date);

            return parkingLot;
         }
    }
}
