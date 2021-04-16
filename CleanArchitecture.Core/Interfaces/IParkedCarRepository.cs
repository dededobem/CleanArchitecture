using System;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IParkedCarRepository
    {
        Task SaveParkedCar(string code, string plate, DateTime date);
    }
}
