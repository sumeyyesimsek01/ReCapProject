using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarID=1, BrandID=1, ColorID=1, ModelYear=1984, Description="Mercedes", DailyPrice=1000},
                new Car{CarID=2, BrandID=1, ColorID=2, ModelYear=1975, Description="Mercedes", DailyPrice=750},
                new Car{CarID=3, BrandID=1, ColorID=3, ModelYear=1999, Description="Mercedes", DailyPrice=1500},
                new Car{CarID=4, BrandID=2, ColorID=4, ModelYear=1995, Description="Porsche", DailyPrice=500},
                new Car{CarID=5, BrandID=2, ColorID=5, ModelYear=1998, Description="Porsche", DailyPrice=600}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandID == car.BrandID);
            _cars.Remove(car);
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

        public List<Car> GetByID(int id)
        {
            return _cars.Where(c => c.ColorID == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            carToUptade.CarID = car.CarID;
            carToUptade.BrandID = car.BrandID;
            carToUptade.ColorID = car.ColorID;
        }
    }
}
