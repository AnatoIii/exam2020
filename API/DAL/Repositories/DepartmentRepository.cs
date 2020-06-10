using DAL.Repositories.Abstractions;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
	public class DepartmentRepository : BaseRepository, IDepartmentRepository
	{
		public DepartmentRepository(ShopDBContext dBContext) : base(dBContext)
		{
		}

		public void AddNewProduct(Product product)
		{
			throw new NotImplementedException();
		}
	}
}
