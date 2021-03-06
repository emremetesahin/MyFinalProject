﻿using Core.Utilities.Results;
using Entitiy.Concrete;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetail();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);

    }
}
