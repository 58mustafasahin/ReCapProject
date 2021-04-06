using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);
        
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        
    }
}
