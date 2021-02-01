using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car
            {
                Id = 7,
                BrandId = 2,
                ColorId = 3,
                ModelYear = 2020,
                DailyPrice = 600,
                Description = "Otomatik Vites - Benzinli"
            });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: " + car.Id + " | MarkaId: " + car.BrandId + " | RenkId: " + car.ColorId + " | Model Yılı: " + car.ModelYear
                    + " | Kira Ücreti: " + car.DailyPrice + " | Açıklaması: " + car.Description);
            }
        }
    }
}
