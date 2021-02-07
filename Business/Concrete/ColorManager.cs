using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Car's color added");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Car's color deleted");
        }

        public List<Color> GetAll()
        {
            Console.WriteLine("All Car's Color");
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(cl => cl.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Car's color updated");
        }
    }
}