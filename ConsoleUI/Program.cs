using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
 
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Brand Name : " + car.BrandName + " \t" + "Color : " + car.ColorName + " \t" + "Daily Price : " + car.DailyPrice);
            }

        }
    }
}
