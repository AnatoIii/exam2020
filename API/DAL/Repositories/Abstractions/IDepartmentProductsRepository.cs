using Model.Entities;
using System;

namespace DAL.Repositories.Abstractions
{
	public interface IDepartmentProductsRepository
	{
		void AddProductToDepartment(DepartmentProduct departmentProducts);
		Department GetDepartmentData(Guid departmentId);
	}
}
