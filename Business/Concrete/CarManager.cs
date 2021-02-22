using Business.Abstarct;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IRentDal _carDal;

        public CarManager(IRentDal cardal)
        {
            _carDal = cardal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int carid)
        {
            return _carDal.GetById(carid);
        }
    }
}
