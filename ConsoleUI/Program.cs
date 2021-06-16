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
            Console.WriteLine("---------------------------------------------------------");
            
            var carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car { CarID = 5, BrandID = 1, ColorID = 1, CarName = "Mercedes", Description = "Mercedes Benz", ModelYear = 2003, DailyPrice = 2250 });
            carManager.Add(new Car { CarID = 5, BrandID = 1, ColorID = 1, CarName = "Mercedes", Description = "Mercedes Benz", ModelYear = 2003, DailyPrice = 2250 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name:"+ car.CarName+ " "+"Description:"+ car.Description+ " "+"Model Year:"+ car.ModelYear+ " "+"Daily Price:"+ car.DailyPrice);
                
            }
            Console.WriteLine("----------------------------------------------------------");
            
            ColorManager colorManager = new ColorManager(new EfColorDal());
            
            colorManager.Add(new Color { ColorID = 1, ColorName = "Grey" });
            colorManager.Add(new Color { ColorID = 2, ColorName = "Black" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine($"{color.ColorID} {color.ColorName}");
            }
        }
    }
}
