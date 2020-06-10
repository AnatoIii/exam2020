using BLL.Services.Abstractions;
using DAL.Repositories.Abstractions;
using Model;
using Model.DTOs;
using System;

namespace BLL.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;
		private readonly IDepartmentProductsRepository _departmentProductsRepository;

		public ProductService(IProductRepository productRepository, IDepartmentProductsRepository departmentProductsRepository)
		{
			_productRepository = productRepository;
			_departmentProductsRepository = departmentProductsRepository;
		}

		public Response AddNewProduct(NewProduct product)
		{
			throw new NotImplementedException();
		}

		public Response AddProductToDepartment(NewDepartmentProduct newDepartmentProduct)
		{
			throw new NotImplementedException();
		}

		public DepartmentData GetDepartmentData(Guid departmentId)
		{
			throw new NotImplementedException();
		}
	}
}
