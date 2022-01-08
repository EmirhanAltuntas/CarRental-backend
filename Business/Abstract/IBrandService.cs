using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<BrandDetailDto>> GetBrandDetails();
        IDataResult<List<Brand>> GetBrandsByName(string name);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IResult Add(Brand brand);
    }
}
