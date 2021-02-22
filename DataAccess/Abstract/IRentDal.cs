using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public interface IRentDal
    {
        void Add();
        void Delete();
        void Update();

        List<Car> GetAll();
        List<Car> GetById(int BrandId);
    }
}
