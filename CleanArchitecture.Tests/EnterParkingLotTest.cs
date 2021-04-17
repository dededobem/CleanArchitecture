using Bogus;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.UseCase;
using CleanArchitecture.Infra.Context;
using CleanArchitecture.Infra.Repository;
using Moq;
using Moq.AutoMock;
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
            //Arrrange
            //var parkingLotRepositoryMemory = new ParkingLotRepositoryMemory();
            //var parkingLotRepository = new Mock<CleanArchitectureContext>();

            //var parkingLotRepositorySql = new ParkingLotRepositorySql(parkingLotRepository.Object);
            var mock = new AutoMocker();
            var parkingLotRepositorySql = mock.CreateInstance<CleanArchitectureContext>();

            //var enterParkingLot = new EnterParkingLot(parkingLotRepositorySql.);
            //var getParkingLot = new GetParkingLot(parkingLotRepositorySql);
                        
            ////Act & Assert
            //var parkingLotBeforeEnter = await getParkingLot.Execute("shopping");
            //Assert.Equal(0, parkingLotBeforeEnter.OccupiedSpaces);
            //await enterParkingLot.Execute("shopping", "MMM-0001", DateTime.Now);
            //var parkingLotAfterEnter = await getParkingLot.Execute("shopping");
            //Assert.Equal(1, parkingLotAfterEnter.OccupiedSpaces);
        }

        //[Fact(DisplayName = "Should be closed")]
        //public async Task EnterParkingLot_Execute_ShouldBeClosed()
        //{
        //    //Arrange
        //    var parkingLotRepositoryMemory = new ParkingLotRepositoryMemory();
        //    var enterParkingLot = new EnterParkingLot(parkingLotRepositoryMemory);
        //    var getParkingLot = new GetParkingLot(parkingLotRepositoryMemory);

        //    //Act & Assert
        //    var parkingLot = await getParkingLot.Execute("shopping");         
        //    Assert.True(!parkingLot.IsOpen(new DateTime(2021, 04, 17, 23, 0, 0)));
        //}

        //[Fact(DisplayName = "Should be full")]
        //public async Task EnterParkingLot_Execute_ShouldBeFull()
        //{
        //    //Arrange
        //    var parkingLotRepositoryMemory = new ParkingLotRepositoryMemory();
        //    var enterParkingLot = new EnterParkingLot(parkingLotRepositoryMemory);
        //    var getParkingLot = new GetParkingLot(parkingLotRepositoryMemory);


        //    //Act & Assert
        //    //await enterParkingLot.Execute("shopping", "MMM-0001", DateTime.Now);
        //    //await enterParkingLot.Execute("shopping", "MMM-0002", DateTime.Now);
        //    //await enterParkingLot.Execute("shopping", "MMM-0003", DateTime.Now);
        //    //await enterParkingLot.Execute("shopping", "MMM-0004", DateTime.Now);
        //    //await enterParkingLot.Execute("shopping", "MMM-0005", DateTime.Now);
        //    //await enterParkingLot.Execute("shopping", "MMM-0006", DateTime.Now);
        //    var parkingLot = await getParkingLot.Execute("shopping");
            
        //    Assert.True(!parkingLot.IsFull());
        //}

    }
}
