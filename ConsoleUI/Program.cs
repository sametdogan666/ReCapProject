﻿using Business.Concrete;
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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());





            Console.WriteLine("------------------------------------------Brand Id = 1-------------------------------------------------");
            Console.WriteLine("Id      Color                   Brand                   Model Year      Daily Price     Description");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}{brandManager.GetById(car.BrandId).BrandName}{car.ModelYear}\t\t{car.DailyPrice}\t{car.Description}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------Color Id = 2-------------------------------------------------");
            Console.WriteLine("Id      Color                   Brand                   Model Year      Daily Price     Description");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}{brandManager.GetById(car.BrandId).BrandName}{car.ModelYear}\t\t{car.DailyPrice}\t{car.Description}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------Fiyat Araligi = 100 / 200-------------------------------------");
            Console.WriteLine("Id      Color                   Brand                   Model Year      Daily Price     Description");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetByDailyPrice(100, 200))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}{brandManager.GetById(car.BrandId).BrandName}{car.ModelYear}\t\t{car.DailyPrice}\t{car.Description}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------Tum Araclar--------------------------------------------------");
            Console.WriteLine("Id      Color                   Brand                   Model Year      Daily Price     Description");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}{brandManager.GetById(car.BrandId).BrandName}{car.ModelYear}\t\t{car.DailyPrice}\t{car.Description}");
            }

        }
    }
}