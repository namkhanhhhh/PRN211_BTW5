using System.Collections;
using System.Collections.Generic;
using AutomobileLibraryy.BussinessObject;
namespace AutomobileLibraryy.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carId); 
        void InsertCar(Car car); 
        void DeleteCar(int carId); 
        void UpdateCar(Car car);
    }
}