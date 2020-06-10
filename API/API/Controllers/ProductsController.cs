using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using Model.DTOs;

namespace API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpPost]
		public ActionResult AddNewProduct([FromBody]NewProduct newProduct)
		{
			var response = _productService.AddNewProduct(newProduct);

			return GetReponseResult(response);
		}

		[HttpPost]
		public ActionResult AddProductToDepartment([FromBody]NewDepartmentProduct newDepartmentProduct)
		{
			var response = _productService.AddProductToDepartment(newDepartmentProduct);

			return GetReponseResult(response);
		}

		[HttpGet]
		public DepartmentData GetDepartmentData([FromBody]Guid departmentId)
		{
			return _productService.GetDepartmentData(departmentId);
		}

		private ActionResult GetReponseResult(Response response)
		{
			if (!response.IsSuccessful) {
				return BadRequest(response.Error);
			}

			return Ok();
		}
	}
}
