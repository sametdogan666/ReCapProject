﻿using DataAccess.Abstract;
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
                new Car{CarId=1, BrandId=1,ColorId=1,ModelYear=2018, DailyPrice=300,Description="Manuel Vites - Benzinli"},
                new Car{CarId=2, BrandId=1,ColorId=2,ModelYear=2016, DailyPrice=215,Description="Manuel Vites - Dizel"},
                new Car{CarId=3, BrandId=2,ColorId=3,ModelYear=2020, DailyPrice=500,Description="Otomatik Vites - Benzinli"},
                new Car{CarId=4, BrandId=2,ColorId=3,ModelYear=2014, DailyPrice=185,Description="Otomatik Vites - Dizel"},
                new Car{CarId=5, BrandId=3,ColorId=2,ModelYear=2012, DailyPrice=150,Description="Manuel Vites - Benzinli"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId== Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}