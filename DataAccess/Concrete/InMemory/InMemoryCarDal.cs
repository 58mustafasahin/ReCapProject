﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;        //naming convention

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2007", DailyPrice = 80, Descriptions = "Grey Ford Focus Manual Diesel"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2010", DailyPrice = 125, Descriptions = "White Peugeot 301 Manual Diesel"},
                new Car{Id = 3, BrandId = 3, ColorId = 3, ModelYear = "2021", DailyPrice = 500, Descriptions = "Red Hyundai Tucson Otomatic Hybrid"},
                new Car{Id = 4, BrandId = 4, ColorId = 4, ModelYear = "2012", DailyPrice = 110, Descriptions = "Black Toyota Corolla Manual Fuel Gasoline"},
                new Car{Id = 5, BrandId = 5, ColorId = 5, ModelYear = "2020", DailyPrice = 270, Descriptions = "Blue Opel Astra Otomatic Hybrid"},

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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Descriptions = car.Descriptions;
        }
    }
}
