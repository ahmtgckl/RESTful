using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, RestFulContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (RestFulContext context = new RestFulContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id

                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 ProductName = p.ProductName,
                                 ProductDescription = p.ProductDescription,
                                 CategoryId = c.Id,
                                 CategoryName = c.CategoryName,
                                 CategoryDescription = c.CategoryDescription,
                                 ProductPrice = p.ProductPrice,
                                 ProductCurrency = p.ProductCurrency
                                 
                             };
                return result.ToList();
            }
        }
    }
}
