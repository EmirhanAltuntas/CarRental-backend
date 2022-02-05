using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal; 
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAddedMessage);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeletedMessage);

        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new DataResult<List<Customer>>(_customerDal.GetAll(),true);
        }

        public IDataResult<List<Customer>> GetById(int id)
        {
            return new DataResult<List<Customer>>(_customerDal.GetAll(p=>p.CustomerID==id), true);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomers()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomer(), Messages.CustomersListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdatedMessage);
        }
    }
}
