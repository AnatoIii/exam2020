using Model;
using Model.DTOs;

namespace BLL.Services.Abstractions
{
	public interface IDepartmentService
	{
		Response AddNewDepartment(NewDepartment newDepartment);
	}
}
