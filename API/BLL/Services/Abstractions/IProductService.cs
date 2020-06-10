using Model;
using Model.DTOs;
using System;

namespace BLL.Services.Abstractions
{
	public interface IProductService
	{
		Response AddNewProduct(NewProduct product);
		Response AddProductToDepartment(NewDepartmentProduct newDepartmentProduct);
		DepartmentData GetDepartmentData(Guid departmentId);
	}
}
