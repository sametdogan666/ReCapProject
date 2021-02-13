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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //UserTest();

            //UserAdded();

            //CustomerAdded();

            //RentalAdded(); ----> HATAA VERİYOR TEKRAR BAK

            //CarTest();
            //CarTestOld(carManager, brandManager, colorManager);
            //CarDetailsTest(carManager);
        }
        private static void RentalAdded()
        {
            DateTime RentDate = new DateTime(2021, 2, 14);
            DateTime ReturnDate = new DateTime(2021, 2, 15);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(
                new Rental
                {

                    CarId = 9,
                    CustomerId = 1,
                    RentDate = RentDate,
                    ReturnDate = ReturnDate

                });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(
                new Customer
                {

                    UserId = 11,
                    CompanyName = "AnyCompany"

                });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAdded()
        {
            UserManager user = new UserManager(new EfUserDal());
            var result = user.Add(new User
            {
                FirstName = "Cemile",
                LastName = "Köse",
                Email = "cemile@gmail.com",
                Password = "123456789"
            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager user = new UserManager(new EfUserDal());
            var result = user.GetAll();

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Email);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        private static void CarDetailsTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " Günlük Ücreti: " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        /*private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Id      Brand Name                      Color Name                      Daily Price     ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.CarId}\t{car.BrandName}\t{car.ColorName}\t{car.DailyPrice}");
            }
        }

        private static void CarTestOld(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {

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
        }*/
    }
}
