using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetColorsByName(string name);
        IResult Update(Color color);
        IResult Delete(Color color);
        IResult Add(Color color);
    }
}
