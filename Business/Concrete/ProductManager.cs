using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Ekleme Başarılı");
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Silme Başarılı");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"Listeleme Başarılı");
        }

        public IDataResult<List<Product>> GetById(int Id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.Id == Id));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Güncelleme Başarılı");
        }
    }
}
