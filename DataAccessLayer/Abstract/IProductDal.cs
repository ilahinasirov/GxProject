﻿using Core.DataAccess;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IProductDal : IEntityRepository<Product>
	{
	}
}