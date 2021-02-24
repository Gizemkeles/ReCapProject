using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{   //interface metotları default publictir.kendisi değil
    public interface IColorDal:IEntityRepository<Color>
    {
       
    }
}
