using BLL.Services.Abstractions;
using DAL.Repositories.Abstractions;
using Model;
using Model.DTOs;
using System;

namespace BLL.Services
{
	public class DepartmentService : IDepartmentService
	{
		private readonly IDepartmentRepository _departmentRepository;

		public DepartmentService(IDepartmentRepository departmentRepository)
		{
			_departmentRepository = departmentRepository;
		}

		public Response AddNewDepartment(NewDepartment newDepartment)
		{
			throw new NotImplementedException();
		}
	}
}
