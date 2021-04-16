using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System.Threading.Tasks;

namespace CleanArchitecture.UserCase
{
    public class EnterParkingLot
    {
        private readonly IParkingLotRepository _parkingLotRepository;

        public EnterParkingLot(IParkingLotRepository parkingLotRepository)
        {
            _parkingLotRepository = parkingLotRepository;
        }

        public async Task<ParkingLot> Execute(string code)
        {
            var parkingLot =  await _parkingLotRepository.GetParkingLot(code);
            return parkingLot;
        }
    }
}
