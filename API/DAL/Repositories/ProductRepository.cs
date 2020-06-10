using DAL.Repositories.Abstractions;
using Model.Entities;
using System;

namespace DAL.Repositories
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public ProductRepository(ShopDBContext dBContext) : base(dBContext)
		{
		}

		public void AddNewProduct(Product product)
		{
			throw new NotImplementedException();
		}
	}
}
