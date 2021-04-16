using CleanArchitecture.Core.Entities;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IParkingLotRepository
    {
        Task<ParkingLot> GetParkingLot(string code);
    }
}
