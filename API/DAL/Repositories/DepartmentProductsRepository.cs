using DAL.Repositories.Abstractions;
using Model.Entities;
using System;
namespace DAL.Repositories
{
	public class DepartmentProductsRepository : BaseRepository, IDepartmentProductsRepository
	{
		public DepartmentProductsRepository(ShopDBContext dBContext) : base(dBContext)
		{
		}

		public void AddProductToDepartment(DepartmentProduct departmentProducts)
		{
			throw new NotImplementedException();
		}

		public Department GetDepartmentData(Guid departmentId)
		{
			throw new NotImplementedException();
		}
	}
}
