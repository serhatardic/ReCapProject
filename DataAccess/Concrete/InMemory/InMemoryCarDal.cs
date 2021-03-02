using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //these are our inmemory data. 
            _cars = new List<Car> {
                new Car{ Id = 1, BrandId = 1, ColorId = 3, ModelYear = 2020, DailyPrice = 250, Description = "Toyota Corolla"},
                new Car{ Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 500, Description = "Toyota Supra"},
                new Car{ Id = 3, BrandId = 2, ColorId = 1, ModelYear = 2018, DailyPrice = 150, Description = "Opel Astra"},
                new Car{ Id = 4, BrandId = 3, ColorId = 4, ModelYear = 2011, DailyPrice = 100, Description = "Ford Fiesta"},
                new Car{ Id = 5, BrandId = 3, ColorId = 2, ModelYear = 2009, DailyPrice = 150, Description = "Ford Focus"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(Car car)
        {

        }

        public List<Car> GetById(int gId)
        {
            return _cars.Where(c => c.Id == gId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
