using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsDbContext>, ICarDal
    {
     

        List<CarDetailDto> ICarDal.GetCarDetails()
        {
            using (CarsDbContext context = new CarsDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId

                             select new CarDetailDto
                             { CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };

                return result.ToList();
            }
        }
    }
}
