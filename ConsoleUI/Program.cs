﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;
using Business.Constants;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //BrandTest();
            //ColorTest();

            CustomerTest();

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            /* Customer customer = new Customer { UserId = 2, CompanyName = "Güzel Oto" };
             var result = customerManager.Add(customer);
             Console.WriteLine(result.Success); */

            foreach (var customers in customerManager.GetAll().Data)
            {
                Console.WriteLine(customers.CompanyName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Ekleme
            colorManager.Add(new Color { ColorName = "SteelBlue" });
            //Güncelleme
            colorManager.Update(new Color { ColorId = 2, ColorName = "Cyan" });

            //Silme
            colorManager.Delete(new Color { ColorId = 4 });

            foreach (var colors in colorManager.GetAll().Data)
            {
                Console.WriteLine(colors.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Ekleme
            brandManager.Add(new Brand { BrandName = "Toros" });

            //Güncelleme
            brandManager.Update(new Brand { BrandId = 13, BrandName = "Opel" });

            //Silme
            brandManager.Delete(new Brand { BrandId = 13 });

            //GetAll
            foreach (var brands in brandManager.GetAll().Data)
            {
                Console.WriteLine(brands.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //Güncelleme
            // carManager.Update(new Car { CarId = 1, Description = "Emir's car", BrandId = 3, ColorId = 1, DailyPrice = 500, ModelYear = new DateTime(2014, 01, 01) });


            //Ekleme
            //carManager.Add(new Car { BrandId = 11, ColorId = 5, DailyPrice = 300, ModelYear = new DateTime(2004, 01, 01), Description = "comment" });


            /*Silme
            Console.WriteLine("Silincek Id Girin");
            int Id = Convert.ToInt32(Console.ReadLine());
            carManager.Delete(new Car { CarId = Id });*/

            //ilişkili tablolar
            foreach (var cars in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(cars.CarId + "---" + cars.BrandName + "---" + cars.ColorName + "---" + cars.DailyPrice);

            }
            Console.WriteLine(Messages.CarsListed);
        }




    }
}
