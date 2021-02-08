using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Car added");
            }
            else
            {
                Console.WriteLine("Daily price must be greater than 0");
            }
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car deleted");
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("All Car ");
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(b => b.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(cl => cl.ColorId == id);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _carDal.GetAll(c => c.ModelYear.Contains(year) == true);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car updated");
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
