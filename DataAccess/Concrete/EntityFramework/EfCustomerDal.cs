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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarsDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomer()
        {
            using (CarsDbContext context = new CarsDbContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new CustomerDetailDto {
                                 Id = user.Id,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 CompanyName = customer.CompanyName };


                return result.ToList();

            }
        }
    }
}