﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 BrandId = br.BrandId,
                                 ColorId = co.ColorId,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName.ToString(),
                                 DailyPrice = ca.DailyPrice,
                                 Descriptions = ca.Descriptions,
                                 ModelYear = Convert.ToInt32(ca.ModelYear)
                             };

                return result.ToList();
            }
        }
    }
}
