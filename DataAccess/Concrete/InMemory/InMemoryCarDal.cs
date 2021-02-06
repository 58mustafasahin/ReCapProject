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
        List<Car> _cars;        //naming convention

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2007, DailyPrice = 80000, Description = "İkinci El"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2010, DailyPrice = 125000, Description = "İkinci El"},
                new Car{Id = 3, BrandId = 1, ColorId = 3, ModelYear = 2021, DailyPrice = 500000, Description = "Sıfır"},
                new Car{Id = 4, BrandId = 2, ColorId = 1, ModelYear = 2012, DailyPrice = 110000, Description = "İkinci El"},
                new Car{Id = 5, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 270000, Description = "Sıfır"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();

        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
        }
    }
}
