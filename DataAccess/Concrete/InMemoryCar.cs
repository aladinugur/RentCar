using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemorycar :IRentDal
    {
        List<Car> _cars;
        public InMemorycar()
        {
            _cars = new List<Car>
            {
                new Car{BrandId=1,Id=1,ColorId=1,DailyPrice=300,Description="Audi günlük kiralama",ModelYear=2018},
                new Car{BrandId=2,Id=2,ColorId=2,DailyPrice=400,Description="BMW günlük kiralama",ModelYear=2018},
                new Car{BrandId=2,Id=3,ColorId=2,DailyPrice=500,Description="BMW günlük kiralama",ModelYear=2018},
                new Car{BrandId=3,Id=4,ColorId=1,DailyPrice=600,Description="Mercedes günlük kiralama",ModelYear=2018},
                new Car{BrandId=3,Id=5,ColorId=2,DailyPrice=700,Description="Mercedes günlük kiralama",ModelYear=2018},

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

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int _carId)
        {
            return _cars.Where(c => c.BrandId == _carId).ToList();

        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

      
    }

