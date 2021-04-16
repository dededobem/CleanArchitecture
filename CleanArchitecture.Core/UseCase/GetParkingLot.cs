using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.UseCase
{
    public class GetParkingLot
    {
        private readonly IParkingLotRepository _parkingLotRepository;

        public GetParkingLot(IParkingLotRepository parkingLotRepository)
        {
            _parkingLotRepository = parkingLotRepository;
        }

        public async Task<ParkingLot> Execute(string code) =>
            await _parkingLotRepository.GetParkingLot(code);        
         
    }
}
