using BLL.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;

namespace API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DepartementsController : ControllerBase
	{
		private readonly IDepartmentService _departmentService;
		public DepartementsController(IDepartmentService departmentService)
		{
			_departmentService = departmentService;
		}

		[HttpPost]
		public ActionResult AddNewDepartment([FromBody]NewDepartment newDepartment)
		{
			var response = _departmentService.AddNewDepartment(newDepartment);

			if (!response.IsSuccessful) {
				return BadRequest(response.Error);
			}

			return Ok();
		}
	}
}
