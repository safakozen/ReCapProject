using Core.DataAccess.Entities;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDAL : EFEntityRepositoryBase<Car, ReCapContext>, ICarDAL
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.Id
                             join r in context.Color
                             on c.ColorId equals r.Id
                             select new CarDetailDto { CarName = c.CarName, BrandName = b.Name, ColorName = r.Name, DailyPrice = c.DailyPrice };
                 
     
      

                return result.ToList();

            }
        }
    }
}
