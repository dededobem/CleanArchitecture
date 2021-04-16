using CleanArchitecture.Core.UseCase;
using CleanArchitecture.Infra.Repository;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.Tests
{
    public class EnterParkingLotTest
    {
        [Fact(DisplayName = "Should enter parking lot")]
        public async Task EnterParkingLot_Execute_ShouldEnterParkingLot()
        {
            
            var parkingLotRepositoryMemory = new ParkingLotRepositoryMemory();
            var parkedCarRepositoryMemory = new ParkedCarRepositoryMemory();
            var enterParkingLot = new EnterParkingLot(parkingLotRepositoryMemory, parkedCarRepositoryMemory);
            var getParkingLot = new GetParkingLot(parkingLotRepositoryMemory);
                        
            var parkingLotBeforeEnter = getParkingLot.Execute("shopping");
            Assert.Equal(0, parkingLotBeforeEnter.occupiedSpaces);

            var parkingLot = await enterParkingLot.Execute("shopping", "MMM-0001", DateTime.Now);

            
            Assert.Equal("shopping", parkingLot.Code);
        }
    }
}
