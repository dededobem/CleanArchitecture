using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Repository
{
    public class ParkedCarRepositoryMemory : IParkedCarRepository
    {
        public async Task SaveParkedCar(string code, string plate, DateTime date)
        {
            var parkedCars = new List<ParkedCar>();

            parkedCars.Add(new ParkedCar(code, plate, date));
        }
    }
}
