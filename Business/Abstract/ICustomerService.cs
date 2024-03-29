﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetById(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomers();
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Add(Customer customer); 
    }  
}
