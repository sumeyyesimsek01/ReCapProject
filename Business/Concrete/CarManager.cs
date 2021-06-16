using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0) 
            {
                Console.WriteLine("The car has been added to the system!");
                _carDal.Add(car);
                
            }
            else
            {
                Console.WriteLine("Error. Please try again!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarByBranID(int id)
        {
            return _carDal.GetAll(c => c.BrandID == id);
        }

        public List<Car> GetCarByColorID(int id)
        {
            return _carDal.GetAll(c => c.ColorID == id);
        }

        public void Update(Car car)
        {
           _carDal.Update(car);
        }
    }
}
